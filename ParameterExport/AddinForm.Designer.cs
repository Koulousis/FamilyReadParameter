using Autodesk.Revit.DB;

namespace ParameterExport
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.paramGridView = new System.Windows.Forms.DataGridView();
			this.paramGroupDropDown = new System.Windows.Forms.ComboBox();
			this.selectedFamiliesList = new System.Windows.Forms.ListView();
			this.selectFamiliesBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listViewLabel = new System.Windows.Forms.Label();
			this.gridViewLabel = new System.Windows.Forms.Label();
			this.selectionGroupBox = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.toolTipLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.printGroupBox = new System.Windows.Forms.GroupBox();
			this.paramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paramValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paramGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.selectionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.printGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Info;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.printGroupBox);
			this.panel1.Controls.Add(this.selectionGroupBox);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(912, 570);
			this.panel1.TabIndex = 0;
			// 
			// paramGridView
			// 
			this.paramGridView.AllowUserToDeleteRows = false;
			this.paramGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.paramGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.paramGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.paramGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.paramGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramName,
            this.paramValue});
			this.paramGridView.Location = new System.Drawing.Point(411, 43);
			this.paramGridView.Name = "paramGridView";
			this.paramGridView.ReadOnly = true;
			this.paramGridView.Size = new System.Drawing.Size(476, 360);
			this.paramGridView.TabIndex = 4;
			// 
			// paramGroupDropDown
			// 
			this.paramGroupDropDown.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.paramGroupDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.paramGroupDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.paramGroupDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paramGroupDropDown.FormattingEnabled = true;
			this.paramGroupDropDown.IntegralHeight = false;
			this.paramGroupDropDown.ItemHeight = 13;
			this.paramGroupDropDown.Location = new System.Drawing.Point(6, 96);
			this.paramGroupDropDown.Name = "paramGroupDropDown";
			this.paramGroupDropDown.Size = new System.Drawing.Size(570, 21);
			this.paramGroupDropDown.Sorted = true;
			this.paramGroupDropDown.TabIndex = 3;
			// 
			// selectedFamiliesList
			// 
			this.selectedFamiliesList.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.selectedFamiliesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.selectedFamiliesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedFamiliesList.GridLines = true;
			this.selectedFamiliesList.HideSelection = false;
			this.selectedFamiliesList.Location = new System.Drawing.Point(10, 43);
			this.selectedFamiliesList.MultiSelect = false;
			this.selectedFamiliesList.Name = "selectedFamiliesList";
			this.selectedFamiliesList.Size = new System.Drawing.Size(395, 360);
			this.selectedFamiliesList.TabIndex = 2;
			this.selectedFamiliesList.UseCompatibleStateImageBehavior = false;
			this.selectedFamiliesList.View = System.Windows.Forms.View.List;
			this.selectedFamiliesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.selectedFamiliesList_ItemSelectionChanged);
			// 
			// selectFamiliesBtn
			// 
			this.selectFamiliesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectFamiliesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectFamiliesBtn.Location = new System.Drawing.Point(6, 19);
			this.selectFamiliesBtn.Name = "selectFamiliesBtn";
			this.selectFamiliesBtn.Size = new System.Drawing.Size(570, 67);
			this.selectFamiliesBtn.TabIndex = 1;
			this.selectFamiliesBtn.Text = "Select families";
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
			// listViewLabel
			// 
			this.listViewLabel.AutoSize = true;
			this.listViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewLabel.Location = new System.Drawing.Point(7, 25);
			this.listViewLabel.Name = "listViewLabel";
			this.listViewLabel.Size = new System.Drawing.Size(168, 13);
			this.listViewLabel.TabIndex = 6;
			this.listViewLabel.Text = "Click on family to read paramaters:";
			// 
			// gridViewLabel
			// 
			this.gridViewLabel.AutoSize = true;
			this.gridViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gridViewLabel.Location = new System.Drawing.Point(408, 25);
			this.gridViewLabel.Name = "gridViewLabel";
			this.gridViewLabel.Size = new System.Drawing.Size(351, 13);
			this.gridViewLabel.TabIndex = 7;
			this.gridViewLabel.Text = "Below family parameters are printed and they are grouped by family types:";
			// 
			// selectionGroupBox
			// 
			this.selectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectionGroupBox.Controls.Add(this.label1);
			this.selectionGroupBox.Controls.Add(this.toolTipLabel);
			this.selectionGroupBox.Controls.Add(this.pictureBox2);
			this.selectionGroupBox.Controls.Add(this.selectFamiliesBtn);
			this.selectionGroupBox.Controls.Add(this.paramGroupDropDown);
			this.selectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectionGroupBox.Location = new System.Drawing.Point(10, 10);
			this.selectionGroupBox.Name = "selectionGroupBox";
			this.selectionGroupBox.Size = new System.Drawing.Size(894, 135);
			this.selectionGroupBox.TabIndex = 8;
			this.selectionGroupBox.TabStop = false;
			this.selectionGroupBox.Text = "Load family and select parameter group";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::ParameterExport.Properties.Resources.petpanel;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(908, 56);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = global::ParameterExport.Properties.Resources.ParameterGroupExample;
			this.pictureBox2.Location = new System.Drawing.Point(603, 16);
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
			this.toolTipLabel.Location = new System.Drawing.Point(600, 89);
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
			this.label1.Location = new System.Drawing.Point(599, 104);
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
			this.printGroupBox.Controls.Add(this.selectedFamiliesList);
			this.printGroupBox.Controls.Add(this.listViewLabel);
			this.printGroupBox.Controls.Add(this.gridViewLabel);
			this.printGroupBox.Controls.Add(this.paramGridView);
			this.printGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printGroupBox.Location = new System.Drawing.Point(10, 151);
			this.printGroupBox.Name = "printGroupBox";
			this.printGroupBox.Size = new System.Drawing.Size(894, 409);
			this.printGroupBox.TabIndex = 9;
			this.printGroupBox.TabStop = false;
			this.printGroupBox.Text = "Click and print";
			// 
			// paramName
			// 
			this.paramName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paramName.DefaultCellStyle = dataGridViewCellStyle2;
			this.paramName.HeaderText = "Parameter Name";
			this.paramName.Name = "paramName";
			this.paramName.ReadOnly = true;
			// 
			// paramValue
			// 
			this.paramValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paramValue.DefaultCellStyle = dataGridViewCellStyle3;
			this.paramValue.HeaderText = "Parameter Value";
			this.paramValue.Name = "paramValue";
			this.paramValue.ReadOnly = true;
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
			((System.ComponentModel.ISupportInitialize)(this.paramGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.selectionGroupBox.ResumeLayout(false);
			this.selectionGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.printGroupBox.ResumeLayout(false);
			this.printGroupBox.PerformLayout();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn paramName;
		private System.Windows.Forms.DataGridViewTextBoxColumn paramValue;
	}
}