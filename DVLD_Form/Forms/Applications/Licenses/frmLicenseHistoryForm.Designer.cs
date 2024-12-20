namespace DVLD_Form.Forms.Applications {
  partial class frmLicenseHistoryForm {
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
      this.cntrlDriverLicenses1 = new DVLD_Form.Controls.cntrlDriverLicenses();
      this.cntrlPersonInfo1 = new DVLD_Form.Controls.cntrlPersonInfo();
      this.SuspendLayout();
      // 
      // cntrlDriverLicenses1
      // 
      this.cntrlDriverLicenses1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cntrlDriverLicenses1.Location = new System.Drawing.Point(270, 12);
      this.cntrlDriverLicenses1.Name = "cntrlDriverLicenses1";
      this.cntrlDriverLicenses1.Size = new System.Drawing.Size(738, 423);
      this.cntrlDriverLicenses1.TabIndex = 1;
      // 
      // cntrlPersonInfo1
      // 
      this.cntrlPersonInfo1.Location = new System.Drawing.Point(12, 1);
      this.cntrlPersonInfo1.Name = "cntrlPersonInfo1";
      this.cntrlPersonInfo1.Size = new System.Drawing.Size(252, 539);
      this.cntrlPersonInfo1.TabIndex = 0;
      // 
      // LicenseHistoryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(1006, 539);
      this.Controls.Add(this.cntrlDriverLicenses1);
      this.Controls.Add(this.cntrlPersonInfo1);
      this.Name = "LicenseHistoryForm";
      this.Text = "LicenseHistoryForm";
      this.Load += new System.EventHandler(this.LicenseHistoryForm_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.cntrlPersonInfo cntrlPersonInfo1;
    private Controls.cntrlDriverLicenses cntrlDriverLicenses1;
  }
}