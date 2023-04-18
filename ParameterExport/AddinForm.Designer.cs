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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddinForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.parametersGroupList = new System.Windows.Forms.ListView();
			this.selectedFamiliesList = new System.Windows.Forms.ListView();
			this.selectFamiliesBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
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
			this.panel1.Controls.Add(this.parametersGroupList);
			this.panel1.Controls.Add(this.selectedFamiliesList);
			this.panel1.Controls.Add(this.selectFamiliesBtn);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 388);
			this.panel1.TabIndex = 0;
			// 
			// parametersGroupList
			// 
			this.parametersGroupList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.parametersGroupList.HideSelection = false;
			this.parametersGroupList.Location = new System.Drawing.Point(208, 10);
			this.parametersGroupList.Name = "parametersGroupList";
			this.parametersGroupList.Size = new System.Drawing.Size(198, 320);
			this.parametersGroupList.TabIndex = 3;
			this.parametersGroupList.UseCompatibleStateImageBehavior = false;
			this.parametersGroupList.View = System.Windows.Forms.View.List;
			// 
			// selectedFamiliesList
			// 
			this.selectedFamiliesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.selectedFamiliesList.HideSelection = false;
			this.selectedFamiliesList.Location = new System.Drawing.Point(3, 10);
			this.selectedFamiliesList.Name = "selectedFamiliesList";
			this.selectedFamiliesList.Size = new System.Drawing.Size(198, 320);
			this.selectedFamiliesList.TabIndex = 2;
			this.selectedFamiliesList.UseCompatibleStateImageBehavior = false;
			this.selectedFamiliesList.View = System.Windows.Forms.View.List;
			// 
			// selectFamiliesBtn
			// 
			this.selectFamiliesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.selectFamiliesBtn.Location = new System.Drawing.Point(3, 336);
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
			this.panel2.Location = new System.Drawing.Point(0, 390);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 60);
			this.panel2.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(209)))), ((int)(((byte)(139)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(259, 42);
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
			this.pictureBox1.Size = new System.Drawing.Size(796, 56);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// AddinForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddinForm";
			this.Text = "Export family parameters";
			this.panel1.ResumeLayout(false);
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
		private System.Windows.Forms.ListView parametersGroupList;
	}
}