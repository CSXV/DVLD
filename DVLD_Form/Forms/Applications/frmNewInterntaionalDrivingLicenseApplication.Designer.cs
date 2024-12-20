namespace DVLD_Form.Forms.Applications {
  partial class frmNewInterntaionalDrivingLicenseApplication {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btNext = new System.Windows.Forms.Button();
      this.cntrlLicenseInfo1 = new DVLD_Form.Controls.cntrlLicenseInfo();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btSave = new System.Windows.Forms.Button();
      this.lbCreatedByUserID = new System.Windows.Forms.Label();
      this.lbIssueDate = new System.Windows.Forms.Label();
      this.lbExperationDate = new System.Windows.Forms.Label();
      this.lbLocalLicenseID = new System.Windows.Forms.Label();
      this.lbILA_ID = new System.Windows.Forms.Label();
      this.lbApplicationFees = new System.Windows.Forms.Label();
      this.lbApplicationDate = new System.Windows.Forms.Label();
      this.lbInternationalLicenseID = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(13, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(302, 33);
      this.label1.TabIndex = 3;
      this.label1.Text = "New Int. Driving License";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 45);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(336, 700);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btNext);
      this.tabPage1.Controls.Add(this.cntrlLicenseInfo1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(328, 674);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Person Info";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btNext
      // 
      this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btNext.BackgroundImage = global::DVLD_Form.Properties.Resources.arrow_forward_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
      this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btNext.Location = new System.Drawing.Point(286, 36);
      this.btNext.Name = "btNext";
      this.btNext.Size = new System.Drawing.Size(30, 30);
      this.btNext.TabIndex = 27;
      this.btNext.UseVisualStyleBackColor = false;
      this.btNext.Click += new System.EventHandler(this.btNext_Click);
      // 
      // cntrlLicenseInfo1
      // 
      this.cntrlLicenseInfo1.Location = new System.Drawing.Point(3, 6);
      this.cntrlLicenseInfo1.Name = "cntrlLicenseInfo1";
      this.cntrlLicenseInfo1.Size = new System.Drawing.Size(283, 665);
      this.cntrlLicenseInfo1.TabIndex = 3;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btSave);
      this.tabPage2.Controls.Add(this.lbCreatedByUserID);
      this.tabPage2.Controls.Add(this.lbIssueDate);
      this.tabPage2.Controls.Add(this.lbExperationDate);
      this.tabPage2.Controls.Add(this.lbLocalLicenseID);
      this.tabPage2.Controls.Add(this.lbILA_ID);
      this.tabPage2.Controls.Add(this.lbApplicationFees);
      this.tabPage2.Controls.Add(this.lbApplicationDate);
      this.tabPage2.Controls.Add(this.lbInternationalLicenseID);
      this.tabPage2.Controls.Add(this.label6);
      this.tabPage2.Controls.Add(this.label9);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.label8);
      this.tabPage2.Controls.Add(this.label4);
      this.tabPage2.Controls.Add(this.label7);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(328, 674);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Application Info";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btSave
      // 
      this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btSave.BackgroundImage = global::DVLD_Form.Properties.Resources.check_circle_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
      this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btSave.Location = new System.Drawing.Point(269, 199);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(30, 30);
      this.btSave.TabIndex = 26;
      this.btSave.UseVisualStyleBackColor = false;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // lbCreatedByUserID
      // 
      this.lbCreatedByUserID.AutoSize = true;
      this.lbCreatedByUserID.Location = new System.Drawing.Point(121, 184);
      this.lbCreatedByUserID.Name = "lbCreatedByUserID";
      this.lbCreatedByUserID.Size = new System.Drawing.Size(25, 13);
      this.lbCreatedByUserID.TabIndex = 6;
      this.lbCreatedByUserID.Text = "N/A";
      // 
      // lbIssueDate
      // 
      this.lbIssueDate.AutoSize = true;
      this.lbIssueDate.Location = new System.Drawing.Point(121, 112);
      this.lbIssueDate.Name = "lbIssueDate";
      this.lbIssueDate.Size = new System.Drawing.Size(25, 13);
      this.lbIssueDate.TabIndex = 8;
      this.lbIssueDate.Text = "N/A";
      // 
      // lbExperationDate
      // 
      this.lbExperationDate.AutoSize = true;
      this.lbExperationDate.Location = new System.Drawing.Point(121, 136);
      this.lbExperationDate.Name = "lbExperationDate";
      this.lbExperationDate.Size = new System.Drawing.Size(25, 13);
      this.lbExperationDate.TabIndex = 6;
      this.lbExperationDate.Text = "N/A";
      // 
      // lbLocalLicenseID
      // 
      this.lbLocalLicenseID.AutoSize = true;
      this.lbLocalLicenseID.Location = new System.Drawing.Point(121, 64);
      this.lbLocalLicenseID.Name = "lbLocalLicenseID";
      this.lbLocalLicenseID.Size = new System.Drawing.Size(25, 13);
      this.lbLocalLicenseID.TabIndex = 6;
      this.lbLocalLicenseID.Text = "N/A";
      // 
      // lbILA_ID
      // 
      this.lbILA_ID.AutoSize = true;
      this.lbILA_ID.Location = new System.Drawing.Point(121, 16);
      this.lbILA_ID.Name = "lbILA_ID";
      this.lbILA_ID.Size = new System.Drawing.Size(25, 13);
      this.lbILA_ID.TabIndex = 6;
      this.lbILA_ID.Text = "N/A";
      // 
      // lbApplicationFees
      // 
      this.lbApplicationFees.AutoSize = true;
      this.lbApplicationFees.Location = new System.Drawing.Point(121, 160);
      this.lbApplicationFees.Name = "lbApplicationFees";
      this.lbApplicationFees.Size = new System.Drawing.Size(25, 13);
      this.lbApplicationFees.TabIndex = 5;
      this.lbApplicationFees.Tag = "50";
      this.lbApplicationFees.Text = "N/A";
      // 
      // lbApplicationDate
      // 
      this.lbApplicationDate.AutoSize = true;
      this.lbApplicationDate.Location = new System.Drawing.Point(121, 88);
      this.lbApplicationDate.Name = "lbApplicationDate";
      this.lbApplicationDate.Size = new System.Drawing.Size(25, 13);
      this.lbApplicationDate.TabIndex = 5;
      this.lbApplicationDate.Text = "N/A";
      // 
      // lbInternationalLicenseID
      // 
      this.lbInternationalLicenseID.AutoSize = true;
      this.lbInternationalLicenseID.Location = new System.Drawing.Point(121, 40);
      this.lbInternationalLicenseID.Name = "lbInternationalLicenseID";
      this.lbInternationalLicenseID.Size = new System.Drawing.Size(25, 13);
      this.lbInternationalLicenseID.TabIndex = 5;
      this.lbInternationalLicenseID.Text = "N/A";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(15, 184);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 13);
      this.label6.TabIndex = 4;
      this.label6.Text = "Created By";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label9.Location = new System.Drawing.Point(15, 136);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(94, 13);
      this.label9.TabIndex = 2;
      this.label9.Text = "Expiration Date";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(15, 160);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(99, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Application Fees";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label8.Location = new System.Drawing.Point(15, 64);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(97, 13);
      this.label8.TabIndex = 1;
      this.label8.Text = "Local License ID";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(15, 112);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(68, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Issue Date";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label7.Location = new System.Drawing.Point(15, 40);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(82, 13);
      this.label7.TabIndex = 0;
      this.label7.Text = "I.L License ID";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(15, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Application Date";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(15, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(103, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "I.L Application ID";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Enabled = false;
      this.linkLabel1.Location = new System.Drawing.Point(16, 748);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(109, 13);
      this.linkLabel1.TabIndex = 4;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Show licenses history";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Enabled = false;
      this.linkLabel2.Location = new System.Drawing.Point(131, 748);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(94, 13);
      this.linkLabel2.TabIndex = 4;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "Show licenses info";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      // 
      // NewInterntaionalDrivingLicenseApplication
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(352, 771);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "NewInterntaionalDrivingLicenseApplication";
      this.ShowIcon = false;
      this.Text = "New Interntaional Driving License Application";
      this.Load += new System.EventHandler(this.NewInterntaionalDrivingLicenseApplication_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label lbIssueDate;
    private System.Windows.Forms.Label lbILA_ID;
    private System.Windows.Forms.Label lbInternationalLicenseID;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lbCreatedByUserID;
    private System.Windows.Forms.Label lbExperationDate;
    private System.Windows.Forms.Label lbLocalLicenseID;
    private System.Windows.Forms.Label lbApplicationFees;
    private System.Windows.Forms.Label lbApplicationDate;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.ToolTip toolTip1;
    private Controls.cntrlLicenseInfo cntrlLicenseInfo1;
    private System.Windows.Forms.Button btNext;
    private System.Windows.Forms.Button btSave;
  }
}