namespace DVLD_Form.Forms.Applications {
  partial class Manage_Detain_Licenses {
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
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btNext = new System.Windows.Forms.Button();
      this.cntrlLicenseInfo2 = new DVLD_Form.Controls.cntrlLicenseInfo();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btSave = new System.Windows.Forms.Button();
      this.tbFees = new System.Windows.Forms.TextBox();
      this.lbCreatedByUserID = new System.Windows.Forms.Label();
      this.lbILA_ID = new System.Windows.Forms.Label();
      this.lbApplicationDate = new System.Windows.Forms.Label();
      this.lbInternationalLicenseID = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cntrlLicenseInfo1 = new DVLD_Form.Controls.cntrlLicenseInfo();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Enabled = false;
      this.linkLabel2.Location = new System.Drawing.Point(127, 745);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(94, 13);
      this.linkLabel2.TabIndex = 12;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "Show licenses info";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Enabled = false;
      this.linkLabel1.Location = new System.Drawing.Point(12, 745);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(109, 13);
      this.linkLabel1.TabIndex = 13;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Show licenses history";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(5, 46);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(336, 700);
      this.tabControl1.TabIndex = 11;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btNext);
      this.tabPage1.Controls.Add(this.cntrlLicenseInfo2);
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
      this.btNext.Location = new System.Drawing.Point(287, 35);
      this.btNext.Name = "btNext";
      this.btNext.Size = new System.Drawing.Size(30, 30);
      this.btNext.TabIndex = 26;
      this.btNext.UseVisualStyleBackColor = false;
      this.btNext.Click += new System.EventHandler(this.btNext_Click);
      // 
      // cntrlLicenseInfo2
      // 
      this.cntrlLicenseInfo2.Location = new System.Drawing.Point(3, 6);
      this.cntrlLicenseInfo2.Name = "cntrlLicenseInfo2";
      this.cntrlLicenseInfo2.Size = new System.Drawing.Size(278, 665);
      this.cntrlLicenseInfo2.TabIndex = 3;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btSave);
      this.tabPage2.Controls.Add(this.tbFees);
      this.tabPage2.Controls.Add(this.lbCreatedByUserID);
      this.tabPage2.Controls.Add(this.lbILA_ID);
      this.tabPage2.Controls.Add(this.lbApplicationDate);
      this.tabPage2.Controls.Add(this.lbInternationalLicenseID);
      this.tabPage2.Controls.Add(this.label6);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.label7);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.label10);
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
      this.btSave.Location = new System.Drawing.Point(282, 127);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(30, 30);
      this.btSave.TabIndex = 25;
      this.btSave.UseVisualStyleBackColor = false;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // tbFees
      // 
      this.tbFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbFees.Location = new System.Drawing.Point(118, 101);
      this.tbFees.Multiline = true;
      this.tbFees.Name = "tbFees";
      this.tbFees.Size = new System.Drawing.Size(194, 20);
      this.tbFees.TabIndex = 11;
      this.tbFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFees_KeyPress);
      // 
      // lbCreatedByUserID
      // 
      this.lbCreatedByUserID.AutoSize = true;
      this.lbCreatedByUserID.Location = new System.Drawing.Point(115, 82);
      this.lbCreatedByUserID.Name = "lbCreatedByUserID";
      this.lbCreatedByUserID.Size = new System.Drawing.Size(25, 13);
      this.lbCreatedByUserID.TabIndex = 6;
      this.lbCreatedByUserID.Text = "N/A";
      // 
      // lbILA_ID
      // 
      this.lbILA_ID.AutoSize = true;
      this.lbILA_ID.Location = new System.Drawing.Point(115, 16);
      this.lbILA_ID.Name = "lbILA_ID";
      this.lbILA_ID.Size = new System.Drawing.Size(25, 13);
      this.lbILA_ID.TabIndex = 6;
      this.lbILA_ID.Text = "N/A";
      // 
      // lbApplicationDate
      // 
      this.lbApplicationDate.AutoSize = true;
      this.lbApplicationDate.Location = new System.Drawing.Point(115, 60);
      this.lbApplicationDate.Name = "lbApplicationDate";
      this.lbApplicationDate.Size = new System.Drawing.Size(25, 13);
      this.lbApplicationDate.TabIndex = 5;
      this.lbApplicationDate.Text = "N/A";
      // 
      // lbInternationalLicenseID
      // 
      this.lbInternationalLicenseID.AutoSize = true;
      this.lbInternationalLicenseID.Location = new System.Drawing.Point(115, 38);
      this.lbInternationalLicenseID.Name = "lbInternationalLicenseID";
      this.lbInternationalLicenseID.Size = new System.Drawing.Size(25, 13);
      this.lbInternationalLicenseID.TabIndex = 5;
      this.lbInternationalLicenseID.Text = "N/A";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(15, 82);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 13);
      this.label6.TabIndex = 4;
      this.label6.Text = "Created By";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(15, 104);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(59, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Fine Fees";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label7.Location = new System.Drawing.Point(15, 38);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(65, 13);
      this.label7.TabIndex = 0;
      this.label7.Text = "License ID";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(15, 60);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Detain Date";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label10.Location = new System.Drawing.Point(15, 16);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(60, 13);
      this.label10.TabIndex = 0;
      this.label10.Text = "Detain ID";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(322, 33);
      this.label1.TabIndex = 10;
      this.label1.Text = "Detain License Application";
      // 
      // cntrlLicenseInfo1
      // 
      this.cntrlLicenseInfo1.Location = new System.Drawing.Point(15, 45);
      this.cntrlLicenseInfo1.Name = "cntrlLicenseInfo1";
      this.cntrlLicenseInfo1.Size = new System.Drawing.Size(275, 665);
      this.cntrlLicenseInfo1.TabIndex = 9;
      // 
      // DetainLicenseForm
      // 
      this.AcceptButton = this.btNext;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(346, 768);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cntrlLicenseInfo1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "DetainLicenseForm";
      this.ShowIcon = false;
      this.Text = "Detain License Form";
      this.Load += new System.EventHandler(this.DetainLicenseForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private Controls.cntrlLicenseInfo cntrlLicenseInfo2;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox tbFees;
    private System.Windows.Forms.Label lbCreatedByUserID;
    private System.Windows.Forms.Label lbILA_ID;
    private System.Windows.Forms.Label lbApplicationDate;
    private System.Windows.Forms.Label lbInternationalLicenseID;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label1;
    private Controls.cntrlLicenseInfo cntrlLicenseInfo1;
    private System.Windows.Forms.Button btSave;
    private System.Windows.Forms.Button btNext;
  }
}