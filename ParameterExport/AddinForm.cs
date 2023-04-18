using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Form = System.Windows.Forms.Form;

namespace ParameterExport
{
	public partial class AddinForm : Form
	{
		// Let the user select multiple family files
		private List<string> familyFilePaths = new List<string>();
		private List<string> familyNameFromPaths = new List<string>();

		public AddinForm()
		{
			InitializeComponent();
			AddRevitParamGroups();
		}

		private void selectFamiliesBtn_Click(object sender, EventArgs e)
		{
			familyFilePaths = SelectFamilyFiles();
			familyNameFromPaths.Clear();
			selectedFamiliesList.Items.Clear();

			foreach (string familyFilePath in familyFilePaths)
			{
				string familyNameFromPath = familyFilePath.Substring(familyFilePath.LastIndexOf('\\') + 1);
				familyNameFromPath = familyNameFromPath.Substring(0, familyNameFromPath.Length - 4);
				familyNameFromPaths.Add(familyNameFromPath);
				selectedFamiliesList.Items.Add(familyNameFromPath);
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

		public void AddRevitParamGroups()
		{
			parametersGroupList.Items.Add(BuiltInParameterGroup.PG_ELECTRICAL_ENGINEERING.ToString());
			parametersGroupList.Items.Add(BuiltInParameterGroup.PG_TEXT.ToString());
			parametersGroupList.Items.Add(BuiltInParameterGroup.PG_IDENTITY_DATA.ToString());
		}
	}
}
