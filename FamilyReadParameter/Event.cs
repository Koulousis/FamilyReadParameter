using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Electrical;
using Autodesk.Revit.UI;
using System.IO;
using System.Windows.Forms;

namespace FamilyReadParameter
{
	public class Event : IExternalEventHandler
	{
		public string SelectedFamilyPath { get; set; }
		public BuiltInParameterGroup SelectedParameterGroup { get; set; }
		public List<Tuple<string, string, string>> Parameters { get; private set; } = new List<Tuple<string, string, string>>();
		public delegate void EventHandlerCallback();
		public event EventHandlerCallback OnEventHandlerCompleted;
		public bool OpenFamilyInEditor { get; set; } = false;


		public string GetName()
		{
			return "Event";
		}

		public void Execute(UIApplication app)
		{
			if (OpenFamilyInEditor)
			{
				OpenFamilyInEditor = false;
				// Convert the file path to a ModelPath object
				ModelPath modelPath = ModelPathUtils.ConvertUserVisiblePathToModelPath(SelectedFamilyPath);

				// Create an OpenOptions object to control how the file is opened
				OpenOptions openOptions = new OpenOptions();
				openOptions.Audit = false; // Change to true if you want to perform an audit while opening the document

				// Open and activate the family file as a separate document
				UIDocument familyUIDoc = null;
				try
				{
					familyUIDoc = app.OpenAndActivateDocument(modelPath, openOptions, false);
				}
				catch (Exception ex)
				{
					TaskDialog.Show("Error", "Failed to open and activate the family.\n" + ex.Message);
				}

				TaskDialog.Show("Success", "Family opened and activated successfully: " + familyUIDoc.Document.Title);

			}
			else
			{
				Document doc = app.Application.NewProjectDocument(UnitSystem.Metric);

				// Clear the Parameters list before processing a new family.
				Parameters.Clear();

				using (Transaction trans = new Transaction(doc, "Load Family and Read Parameters"))
				{
					trans.Start();
					if (doc.LoadFamily(SelectedFamilyPath, out var family))
					{
						FilteredElementCollector collector = new FilteredElementCollector(doc);
						ICollection<Element> familyTypes = collector.OfClass(typeof(FamilySymbol))
							.OfCategoryId(family.FamilyCategoryId)
							.ToElements();

						string selectedFamilyName = Path.GetFileNameWithoutExtension(SelectedFamilyPath);

						foreach (FamilySymbol familyType in familyTypes)
						{
							if (familyType.FamilyName != selectedFamilyName)
							{
								continue;
							}

							ParameterSet parameters = familyType.Parameters;
							foreach (Parameter param in parameters)
							{
								if (param.Definition.ParameterGroup == SelectedParameterGroup)
								{
									string paramName = param.Definition.Name;
									string paramValue = param.AsValueString();

									Parameters.Add(new Tuple<string, string, string>(familyType.Name, paramName, paramValue));
								}
							}
						}

						trans.Commit();
					}
					else
					{
						trans.RollBack();
					}

					// Invoke the event when the event handler is completed
					OnEventHandlerCompleted?.Invoke();
				}
			}
		}
	}

}
