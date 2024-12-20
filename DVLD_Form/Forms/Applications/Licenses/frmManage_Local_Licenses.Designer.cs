namespace DVLD_Form.Forms.Applications
{
    partial class LocalLicensesForm
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
      this.components = new System.ComponentModel.Container();
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.cbFilter = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sechduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.streetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.showPersonLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbFilter
      // 
      this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.tbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbFilter.Location = new System.Drawing.Point(234, 87);
      this.tbFilter.Name = "tbFilter";
      this.tbFilter.Size = new System.Drawing.Size(167, 20);
      this.tbFilter.TabIndex = 11;
      this.tbFilter.Visible = false;
      this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
      this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
      // 
      // cbFilter
      // 
      this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.cbFilter.FormattingEnabled = true;
      this.cbFilter.Items.AddRange(new object[] {
            "None",
            "LocalDrivingLicenseApplicationID",
            "NationalNo",
            "Status",
            "FullName"});
      this.cbFilter.Location = new System.Drawing.Point(60, 87);
      this.cbFilter.Name = "cbFilter";
      this.cbFilter.Size = new System.Drawing.Size(167, 21);
      this.cbFilter.TabIndex = 10;
      this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Filter By:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(431, 33);
      this.label1.TabIndex = 8;
      this.label1.Text = "Manage Local Licenses Applications";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
      this.dataGridView1.Location = new System.Drawing.Point(0, 114);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(1207, 378);
      this.dataGridView1.TabIndex = 7;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.cancelApplicationToolStripMenuItem,
            this.sechduleTestsToolStripMenuItem,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator3,
            this.showPersonLiToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(246, 198);
      this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
      // 
      // showApplicationDetailsToolStripMenuItem
      // 
      this.showApplicationDetailsToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.info;
      this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
      this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
      this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
      this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
      // 
      // editApplicationToolStripMenuItem
      // 
      this.editApplicationToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.edit;
      this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
      this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
      this.editApplicationToolStripMenuItem.Text = "Edit Application";
      this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
      // 
      // deleteApplicationToolStripMenuItem
      // 
      this.deleteApplicationToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.delete;
      this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
      this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
      this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
      this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
      // 
      // cancelApplicationToolStripMenuItem
      // 
      this.cancelApplicationToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.cancel;
      this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
      this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
      this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
      this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
      // 
      // sechduleTestsToolStripMenuItem
      // 
      this.sechduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eyeToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.streetTestToolStripMenuItem});
      this.sechduleTestsToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.schedule;
      this.sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
      this.sechduleTestsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
      this.sechduleTestsToolStripMenuItem.Text = "Schedule Tests";
      // 
      // eyeToolStripMenuItem
      // 
      this.eyeToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.visibility;
      this.eyeToolStripMenuItem.Name = "eyeToolStripMenuItem";
      this.eyeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.eyeToolStripMenuItem.Text = "Eye Vision Test";
      this.eyeToolStripMenuItem.Click += new System.EventHandler(this.eyeToolStripMenuItem_Click);
      // 
      // writtenTestToolStripMenuItem
      // 
      this.writtenTestToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.edit_document;
      this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
      this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.writtenTestToolStripMenuItem.Text = "Written Test";
      this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.writtenTestToolStripMenuItem_Click);
      // 
      // streetTestToolStripMenuItem
      // 
      this.streetTestToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.directions_car;
      this.streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
      this.streetTestToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.streetTestToolStripMenuItem.Text = "Street Test";
      this.streetTestToolStripMenuItem.Click += new System.EventHandler(this.streetTestToolStripMenuItem_Click);
      // 
      // issueDrivingLicenseFirstTimeToolStripMenuItem
      // 
      this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.add_card;
      this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
      this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
      this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
      this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
      // 
      // showLicenseToolStripMenuItem
      // 
      this.showLicenseToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.preview;
      this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
      this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
      this.showLicenseToolStripMenuItem.Text = "Show License";
      this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
      // 
      // showPersonLiToolStripMenuItem
      // 
      this.showPersonLiToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.history;
      this.showPersonLiToolStripMenuItem.Name = "showPersonLiToolStripMenuItem";
      this.showPersonLiToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
      this.showPersonLiToolStripMenuItem.Text = "Show Person License History";
      this.showPersonLiToolStripMenuItem.Click += new System.EventHandler(this.showPersonLiToolStripMenuItem_Click);
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button2.BackgroundImage = global::DVLD_Form.Properties.Resources.refresh_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button2.Location = new System.Drawing.Point(1120, 68);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(35, 35);
      this.button2.TabIndex = 24;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button1.BackgroundImage = global::DVLD_Form.Properties.Resources.docs_add_on_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button1.Location = new System.Drawing.Point(1161, 68);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(35, 35);
      this.button1.TabIndex = 23;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // LocalLicensesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(1208, 493);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.tbFilter);
      this.Controls.Add(this.cbFilter);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "LocalLicensesForm";
      this.ShowIcon = false;
      this.Text = "Manage Local Licenses";
      this.Load += new System.EventHandler(this.LocalLicensesForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showPersonLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
  }
}