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

namespace ParameterExport
{
	public class Event : IExternalEventHandler
	{
		public string GetName()
		{
			return "Event";
		}

		public void Execute(UIApplication app)
		{
			AddinForm addinForm = new AddinForm();
			addinForm.Show();
		    Document doc = app.Application.NewProjectDocument(UnitSystem.Metric);

		    // Let the user select multiple family files
		    List<string> familyFilePaths = SelectFamilyFiles();

		    // Create a list to store the parameters and their values
		    List<string> parameterList = new List<string>();

		    foreach (string familyFilePath in familyFilePaths)
		    {
			    //Take the family name from file path
			    string familyNameFromPath = familyFilePath.Substring(familyFilePath.LastIndexOf('\\') + 1);
			    familyNameFromPath = familyNameFromPath.Substring(0, familyNameFromPath.Length - 4);

			    // Load the family
			    using (Transaction trans = new Transaction(doc, "Load Family"))
			    {
				    trans.Start();
				    if (doc.LoadFamily(familyFilePath, out var family))
				    {
					    trans.Commit();

					    // Get all family types
					    FilteredElementCollector collector = new FilteredElementCollector(doc);
					    ICollection<Element> familyTypes = collector.OfClass(typeof(FamilySymbol))
						    .OfCategoryId(family.FamilyCategoryId)
						    .ToElements();

					    // Iterate through family types to find Electrical engineering group parameters
					    foreach (FamilySymbol familyType in familyTypes)
					    {
						    if (familyType.FamilyName != familyNameFromPath)
						    {
							    continue;
						    }

						    // Add the family type name to the list
						    parameterList.Add($"{familyType.Name}");

						    // Get the family type's Electrical engineering parameters
						    ParameterSet parameters = familyType.Parameters;
						    foreach (Parameter param in parameters)
						    {
							    // Check if the parameter's group is Electrical engineering
							    if (param.Definition.ParameterGroup == BuiltInParameterGroup.PG_ELECTRICAL_ENGINEERING)
							    {
								    // Retrieve parameter name and value
								    string paramName = param.Definition.Name;
								    string paramValue = param.AsValueString();

								    // Add the parameter name and value to the list
								    parameterList.Add($"{paramName}: {paramValue}");
							    }
						    }

						    parameterList.Add("---------------------------------");
					    }

					    // Write the parameters to a file
					    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					    string exportFolderPath = Path.Combine(desktopPath, "Exported Parameters");
					    Directory.CreateDirectory(exportFolderPath);
					    string outputFilePath = Path.Combine(exportFolderPath, familyNameFromPath + ".txt");
					    WriteParametersToFile(outputFilePath, parameterList);
				    }
				    else
				    {
					    trans.RollBack();
				    }
			    }
		    }
		}

		public List<string> SelectFamilyFiles()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Revit Family Files (*.rfa)|*.rfa",
				Title = "Select Family Files",
				Multiselect = true
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				return openFileDialog.FileNames.ToList();
			}

			return null;
		}

		private void WriteParametersToFile(string filePath, List<string> parameters)
		{
			using (StreamWriter sw = new StreamWriter(filePath))
			{
				foreach (string parameter in parameters)
				{
					sw.WriteLine(parameter);
				}
			}
		}
	}
}
