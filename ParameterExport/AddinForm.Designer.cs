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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.readParamsBtn = new System.Windows.Forms.Button();
			this.paramGridView = new System.Windows.Forms.DataGridView();
			this.paramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paramValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paramGroupDropDown = new System.Windows.Forms.ComboBox();
			this.selectedFamiliesList = new System.Windows.Forms.ListView();
			this.selectFamiliesBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paramGridView)).BeginInit();
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
			this.panel1.Controls.Add(this.readParamsBtn);
			this.panel1.Controls.Add(this.paramGridView);
			this.panel1.Controls.Add(this.paramGroupDropDown);
			this.panel1.Controls.Add(this.selectedFamiliesList);
			this.panel1.Controls.Add(this.selectFamiliesBtn);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(584, 499);
			this.panel1.TabIndex = 0;
			// 
			// readParamsBtn
			// 
			this.readParamsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.readParamsBtn.Location = new System.Drawing.Point(208, 447);
			this.readParamsBtn.Name = "readParamsBtn";
			this.readParamsBtn.Size = new System.Drawing.Size(362, 45);
			this.readParamsBtn.TabIndex = 5;
			this.readParamsBtn.Text = "Read parameters";
			this.readParamsBtn.UseVisualStyleBackColor = true;
			this.readParamsBtn.Click += new System.EventHandler(this.readParamsBtn_Click);
			// 
			// paramGridView
			// 
			this.paramGridView.AllowUserToDeleteRows = false;
			this.paramGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.paramGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.paramGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramName,
            this.paramValue});
			this.paramGridView.Location = new System.Drawing.Point(208, 38);
			this.paramGridView.Name = "paramGridView";
			this.paramGridView.ReadOnly = true;
			this.paramGridView.Size = new System.Drawing.Size(362, 403);
			this.paramGridView.TabIndex = 4;
			// 
			// paramName
			// 
			this.paramName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paramName.DefaultCellStyle = dataGridViewCellStyle1;
			this.paramName.HeaderText = "Parameter Name";
			this.paramName.Name = "paramName";
			this.paramName.ReadOnly = true;
			// 
			// paramValue
			// 
			this.paramValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.paramValue.DefaultCellStyle = dataGridViewCellStyle2;
			this.paramValue.HeaderText = "Parameter Value";
			this.paramValue.Name = "paramValue";
			this.paramValue.ReadOnly = true;
			// 
			// paramGroupDropDown
			// 
			this.paramGroupDropDown.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.paramGroupDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.paramGroupDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.paramGroupDropDown.FormattingEnabled = true;
			this.paramGroupDropDown.IntegralHeight = false;
			this.paramGroupDropDown.ItemHeight = 13;
			this.paramGroupDropDown.Location = new System.Drawing.Point(208, 10);
			this.paramGroupDropDown.Name = "paramGroupDropDown";
			this.paramGroupDropDown.Size = new System.Drawing.Size(362, 21);
			this.paramGroupDropDown.Sorted = true;
			this.paramGroupDropDown.TabIndex = 3;
			// 
			// selectedFamiliesList
			// 
			this.selectedFamiliesList.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.selectedFamiliesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.selectedFamiliesList.GridLines = true;
			this.selectedFamiliesList.HideSelection = false;
			this.selectedFamiliesList.Location = new System.Drawing.Point(3, 10);
			this.selectedFamiliesList.MultiSelect = false;
			this.selectedFamiliesList.Name = "selectedFamiliesList";
			this.selectedFamiliesList.Size = new System.Drawing.Size(198, 431);
			this.selectedFamiliesList.TabIndex = 2;
			this.selectedFamiliesList.UseCompatibleStateImageBehavior = false;
			this.selectedFamiliesList.View = System.Windows.Forms.View.List;
			this.selectedFamiliesList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.selectedFamiliesList_ItemSelectionChanged);
			// 
			// selectFamiliesBtn
			// 
			this.selectFamiliesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.selectFamiliesBtn.Location = new System.Drawing.Point(3, 447);
			this.selectFamiliesBtn.Name = "selectFamiliesBtn";
			this.selectFamiliesBtn.Size = new System.Drawing.Size(198, 45);
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
			this.panel2.Location = new System.Drawing.Point(0, 501);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(584, 60);
			this.panel2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(209)))), ((int)(((byte)(139)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(151, 42);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(284, 11);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "© Copyrights - Petersime NV 2023";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::ParameterExport.Properties.Resources.petpanel;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(580, 56);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// AddinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 561);
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
		private System.Windows.Forms.Button readParamsBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn paramName;
		private System.Windows.Forms.DataGridViewTextBoxColumn paramValue;
	}
}