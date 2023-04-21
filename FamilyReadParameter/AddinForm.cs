using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Color = System.Drawing.Color;
using Form = System.Windows.Forms.Form;

namespace FamilyReadParameter
{
	public partial class AddinForm : Form
	{
		// Let the user select multiple family files
		private List<string> _familyFilePaths = new List<string>();
		private List<string> _familyNamesFromPaths = new List<string>();
		private Array parameterGroups = Enum.GetValues(typeof(BuiltInParameterGroup));
		private Event _eventHandler;
		private UIApplication _app;

		public AddinForm(UIApplication app, Event eventHandler)
		{
			InitializeComponent();
			FillComboBoxWithParamGroups();
			_app = app;
			_eventHandler = eventHandler;
			Command._handler.OnEventHandlerCompleted += UpdateParamGridView;
		}

		#region Events
		private void selectFamiliesBtn_Click(object sender, EventArgs e)
		{
			_familyFilePaths = SelectFamilyFiles();
			if (_familyFilePaths.Count == 0 || _familyFilePaths == null) return;

			_familyNamesFromPaths.Clear();
			selectedFamiliesList.Items.Clear();

			foreach (string familyFilePath in _familyFilePaths)
			{
				string familyNameFromPath = familyFilePath.Substring(familyFilePath.LastIndexOf('\\') + 1);
				familyNameFromPath = familyNameFromPath.Substring(0, familyNameFromPath.Length - 4);
				_familyNamesFromPaths.Add(familyNameFromPath);
				selectedFamiliesList.Items.Add(familyNameFromPath);
			}
		}

		private void selectedFamiliesList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			// Check if there is at least one item selected
			if (selectedFamiliesList.SelectedItems.Count == 0)
			{
				return;
			}

			string selectedFamilyName = selectedFamiliesList.SelectedItems[0].Text;
			string selectedFamilyPath = _familyFilePaths.Find(path => path.Contains(selectedFamilyName));
			
			_eventHandler.SelectedFamilyPath = selectedFamilyPath;
			_eventHandler.SelectedParameterGroup = (BuiltInParameterGroup)Enum.Parse(typeof(BuiltInParameterGroup), $"PG_{paramGroupDropDown.SelectedItem}");

			selectedFamilyTextBox.Text = selectedFamilyName;
			Command._externalEvent.Raise();
		}

		private void openInRevitBtn_Click(object sender, EventArgs e)
		{
			if (selectedFamiliesList.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please select a family file first.");
				return;
			}

			string selectedFamilyName = selectedFamiliesList.SelectedItems[0].Text;
			string selectedFamilyPath = _familyFilePaths.Find(path => path.Contains(selectedFamilyName));

			// Open the selected family file in the current Revit instance.
			OpenFamilyInCurrentRevitInstance(selectedFamilyPath);
		}
		#endregion

		#region Methods
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

		public void FillComboBoxWithParamGroups()
		{
			foreach (BuiltInParameterGroup group in parameterGroups)
			{
				paramGroupDropDown.Items.Add(group.ToString().Replace("PG_",String.Empty));
			}

			paramGroupDropDown.SelectedIndex = 53;
		}

		private void UpdateParamGridView()
		{
			paramGridView.Rows.Clear();

			if (_eventHandler.Parameters.Count == 0)
			{
				return;
			}

			string currentGroupName = string.Empty;
			foreach (var param in _eventHandler.Parameters.OrderBy(x => x.Item1))
			{
				string groupName = param.Item1.ToString();

				if (currentGroupName != groupName)
				{
					AddGroupHeader(paramGridView, groupName);
					currentGroupName = groupName;
				}

				DataGridViewRow row = new DataGridViewRow();
				// Remove the first column cell and adjust the cell indexes.
				row.Cells.Add(new DataGridViewTextBoxCell { Value = param.Item2 });
				row.Cells.Add(new DataGridViewTextBoxCell { Value = param.Item3 });

				paramGridView.Rows.Add(row);
			}
		}
		
		private void AddGroupHeader(DataGridView dataGridView, string headerText)
		{
			DataGridViewRow groupHeaderRow = new DataGridViewRow();
			groupHeaderRow.Height = 20;
			groupHeaderRow.DefaultCellStyle.BackColor = Color.PaleGreen;
			groupHeaderRow.DefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);

			DataGridViewTextBoxCell headerCell = new DataGridViewTextBoxCell();
			headerCell.Value = headerText;
			headerCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
			headerCell.Style.BackColor = Color.PaleGreen;

			groupHeaderRow.Cells.Add(headerCell);
			dataGridView.Rows.Add(groupHeaderRow);
		}

		public void OpenFamilyInCurrentRevitInstance(string familyPath)
		{
			if (selectedFamiliesList.SelectedItems.Count == 0)
			{
				MessageBox.Show("Please select a family file first.");
				return;
			}

			// Open the selected family file in the current Revit instance.
			_eventHandler.SelectedFamilyPath = familyPath;
			_eventHandler.OpenFamilyInEditor = true;
			Command._externalEvent.Raise();
		}

		#endregion
	}
}
