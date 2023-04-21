using Autodesk.Revit.DB;

namespace FamilyReadParameter
{
	partial class AddinForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.infoGroupBox = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.toolTipLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.printGroupBox = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.selectedFamilyTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.selectedFamiliesList = new System.Windows.Forms.ListView();
			this.listViewLabel = new System.Windows.Forms.Label();
			this.gridViewLabel = new System.Windows.Forms.Label();
			this.paramGridView = new System.Windows.Forms.DataGridView();
			this.paramGroupDropDown = new System.Windows.Forms.ComboBox();
			this.selectionGroupBox = new System.Windows.Forms.GroupBox();
			this.openInRevitBtn = new System.Windows.Forms.Button();
			this.openLabel = new System.Windows.Forms.Label();
			this.loadLabel = new System.Windows.Forms.Label();
			this.selectFamiliesBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.paramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paramValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.infoGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.printGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paramGridView)).BeginInit();
			this.selectionGroupBox.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Info;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.infoGroupBox);
			this.panel1.Controls.Add(this.printGroupBox);
			this.panel1.Controls.Add(this.selectionGroupBox);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(912, 570);
			this.panel1.TabIndex = 0;
			// 
			// infoGroupBox
			// 
			this.infoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.infoGroupBox.Controls.Add(this.pictureBox2);
			this.infoGroupBox.Controls.Add(this.toolTipLabel);
			this.infoGroupBox.Controls.Add(this.label1);
			this.infoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.infoGroupBox.Location = new System.Drawing.Point(603, 11);
			this.infoGroupBox.Name = "infoGroupBox";
			this.infoGroupBox.Size = new System.Drawing.Size(301, 134);
			this.infoGroupBox.TabIndex = 10;
			this.infoGroupBox.TabStop = false;
			this.infoGroupBox.Text = "Informations";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = global::FamilyReadParameter.Properties.Resources.ParameterGroupExample;
			this.pictureBox2.Location = new System.Drawing.Point(9, 19);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(285, 70);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// toolTipLabel
			// 
			this.toolTipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.toolTipLabel.AutoSize = true;
			this.toolTipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolTipLabel.Location = new System.Drawing.Point(6, 92);
			this.toolTipLabel.Name = "toolTipLabel";
			this.toolTipLabel.Size = new System.Drawing.Size(284, 13);
			this.toolTipLabel.TabIndex = 7;
			this.toolTipLabel.Text = "Example of where to check the name of a parameter group";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = " into Revit properties window";
			// 
			// printGroupBox
			// 
			this.printGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.printGroupBox.Controls.Add(this.label3);
			this.printGroupBox.Controls.Add(this.selectedFamilyTextBox);
			this.printGroupBox.Controls.Add(this.label2);
			this.printGroupBox.Controls.Add(this.selectedFamiliesList);
			this.printGroupBox.Controls.Add(this.listViewLabel);
			this.printGroupBox.Controls.Add(this.gridViewLabel);
			this.printGroupBox.Controls.Add(this.paramGridView);
			this.printGroupBox.Controls.Add(this.paramGroupDropDown);
			this.printGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printGroupBox.Location = new System.Drawing.Point(10, 151);
			this.printGroupBox.Name = "printGroupBox";
			this.printGroupBox.Size = new System.Drawing.Size(894, 409);
			this.printGroupBox.TabIndex = 9;
			this.printGroupBox.TabStop = false;
			this.printGroupBox.Text = "Select and print";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(408, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Selected family:";
			// 
			// selectedFamilyTextBox
			// 
			this.selectedFamilyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectedFamilyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedFamilyTextBox.Location = new System.Drawing.Point(412, 43);
			this.selectedFamilyTextBox.Name = "selectedFamilyTextBox";
			this.selectedFamilyTextBox.ReadOnly = true;
			this.selectedFamilyTextBox.Size = new System.Drawing.Size(471, 20);
			this.selectedFamilyTextBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Select parameter group:";
			// 
			// selectedFamiliesList
			// 
			this.selectedFamiliesList.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.selectedFamiliesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.selectedFamiliesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedFamiliesList.GridLines = true;
			this.selectedFamiliesList.HideSelection = false;
			this.selectedFamiliesList.Location = new System.Drawing.Point(10, 88);
			this.selectedFamiliesList.MultiSelect = false;
			this.selectedFamiliesList.Name = "selectedFamiliesList";
			this.selectedFamiliesList.Size = new System.Drawing.Size(395, 315);
			this.selectedFamiliesList.TabIndex = 2;
			this.selectedFamiliesList.UseCompatibleStateImageBehavior = false;
			this.selectedFamiliesList.View = System.Windows.Forms.View.List;
			this.selectedFamiliesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.selectedFamiliesList_ItemSelectionChanged);
			// 
			// listViewLabel
			// 
			this.listViewLabel.AutoSize = true;
			this.listViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewLabel.Location = new System.Drawing.Point(8, 70);
			this.listViewLabel.Name = "listViewLabel";
			this.listViewLabel.Size = new System.Drawing.Size(168, 13);
			this.listViewLabel.TabIndex = 6;
			this.listViewLabel.Text = "Click on family to read paramaters:";
			// 
			// gridViewLabel
			// 
			this.gridViewLabel.AutoSize = true;
			this.gridViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewLabel.Location = new System.Drawing.Point(408, 70);
			this.gridViewLabel.Name = "gridViewLabel";
			this.gridViewLabel.Size = new System.Drawing.Size(351, 13);
			this.gridViewLabel.TabIndex = 7;
			this.gridViewLabel.Text = "Below family parameters are printed and they are grouped by family types:";
			// 
			// paramGridView
			// 
			this.paramGridView.AllowUserToDeleteRows = false;
			this.paramGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.paramGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.paramGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.paramGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramName,
            this.paramValue});
			this.paramGridView.Location = new System.Drawing.Point(411, 88);
			this.paramGridView.Name = "paramGridView";
			this.paramGridView.ReadOnly = true;
			this.paramGridView.Size = new System.Drawing.Size(476, 315);
			this.paramGridView.TabIndex = 4;
			// 
			// paramGroupDropDown
			// 
			this.paramGroupDropDown.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.paramGroupDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.paramGroupDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paramGroupDropDown.FormattingEnabled = true;
			this.paramGroupDropDown.IntegralHeight = false;
			this.paramGroupDropDown.ItemHeight = 13;
			this.paramGroupDropDown.Location = new System.Drawing.Point(10, 43);
			this.paramGroupDropDown.Name = "paramGroupDropDown";
			this.paramGroupDropDown.Size = new System.Drawing.Size(395, 21);
			this.paramGroupDropDown.Sorted = true;
			this.paramGroupDropDown.TabIndex = 3;
			// 
			// selectionGroupBox
			// 
			this.selectionGroupBox.Controls.Add(this.openInRevitBtn);
			this.selectionGroupBox.Controls.Add(this.openLabel);
			this.selectionGroupBox.Controls.Add(this.loadLabel);
			this.selectionGroupBox.Controls.Add(this.selectFamiliesBtn);
			this.selectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectionGroupBox.Location = new System.Drawing.Point(10, 10);
			this.selectionGroupBox.Name = "selectionGroupBox";
			this.selectionGroupBox.Size = new System.Drawing.Size(189, 135);
			this.selectionGroupBox.TabIndex = 8;
			this.selectionGroupBox.TabStop = false;
			this.selectionGroupBox.Text = "Options: Load - Open into";
			// 
			// openInRevitBtn
			// 
			this.openInRevitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openInRevitBtn.Image = global::FamilyReadParameter.Properties.Resources.openInRevit;
			this.openInRevitBtn.Location = new System.Drawing.Point(116, 49);
			this.openInRevitBtn.Name = "openInRevitBtn";
			this.openInRevitBtn.Size = new System.Drawing.Size(50, 50);
			this.openInRevitBtn.TabIndex = 11;
			this.openInRevitBtn.UseVisualStyleBackColor = true;
			this.openInRevitBtn.Click += new System.EventHandler(this.openInRevitBtn_Click);
			// 
			// openLabel
			// 
			this.openLabel.AutoSize = true;
			this.openLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openLabel.Location = new System.Drawing.Point(104, 33);
			this.openLabel.Name = "openLabel";
			this.openLabel.Size = new System.Drawing.Size(72, 13);
			this.openLabel.TabIndex = 10;
			this.openLabel.Text = "Open in Revit";
			// 
			// loadLabel
			// 
			this.loadLabel.AutoSize = true;
			this.loadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadLabel.Location = new System.Drawing.Point(7, 33);
			this.loadLabel.Name = "loadLabel";
			this.loadLabel.Size = new System.Drawing.Size(71, 13);
			this.loadLabel.TabIndex = 9;
			this.loadLabel.Text = "Load Families";
			// 
			// selectFamiliesBtn
			// 
			this.selectFamiliesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectFamiliesBtn.Image = global::FamilyReadParameter.Properties.Resources.loadFamilies40x40;
			this.selectFamiliesBtn.Location = new System.Drawing.Point(17, 49);
			this.selectFamiliesBtn.Name = "selectFamiliesBtn";
			this.selectFamiliesBtn.Size = new System.Drawing.Size(50, 50);
			this.selectFamiliesBtn.TabIndex = 1;
			this.selectFamiliesBtn.UseVisualStyleBackColor = true;
			this.selectFamiliesBtn.Click += new System.EventHandler(this.selectFamiliesBtn_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(209)))), ((int)(((byte)(139)))));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 572);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(912, 60);
			this.panel2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(209)))), ((int)(((byte)(139)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(315, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(284, 11);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "© Copyrights - Petersime NV 2023";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::FamilyReadParameter.Properties.Resources.petpanel;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(908, 56);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// paramName
			// 
			this.paramName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paramName.DefaultCellStyle = dataGridViewCellStyle1;
			this.paramName.HeaderText = "Parameter Name";
			this.paramName.Name = "paramName";
			this.paramName.ReadOnly = true;
			this.paramName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// paramValue
			// 
			this.paramValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paramValue.DefaultCellStyle = dataGridViewCellStyle2;
			this.paramValue.HeaderText = "Parameter Value";
			this.paramValue.Name = "paramValue";
			this.paramValue.ReadOnly = true;
			this.paramValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// AddinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 632);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(600, 600);
			this.Name = "AddinForm";
			this.Text = "Export family parameters";
			this.panel1.ResumeLayout(false);
			this.infoGroupBox.ResumeLayout(false);
			this.infoGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.printGroupBox.ResumeLayout(false);
			this.printGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.paramGridView)).EndInit();
			this.selectionGroupBox.ResumeLayout(false);
			this.selectionGroupBox.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button selectFamiliesBtn;
		private System.Windows.Forms.ListView selectedFamiliesList;
		private System.Windows.Forms.ComboBox paramGroupDropDown;
		private System.Windows.Forms.DataGridView paramGridView;
		private System.Windows.Forms.GroupBox selectionGroupBox;
		private System.Windows.Forms.Label gridViewLabel;
		private System.Windows.Forms.Label listViewLabel;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.GroupBox printGroupBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label toolTipLabel;
		private System.Windows.Forms.Button openInRevitBtn;
		private System.Windows.Forms.Label openLabel;
		private System.Windows.Forms.Label loadLabel;
		private System.Windows.Forms.GroupBox infoGroupBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox selectedFamilyTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn paramName;
		private System.Windows.Forms.DataGridViewTextBoxColumn paramValue;
	}
}