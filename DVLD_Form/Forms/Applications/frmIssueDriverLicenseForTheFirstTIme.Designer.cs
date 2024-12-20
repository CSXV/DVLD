namespace DVLD_Form.Forms.Applications {
  partial class frmIssueDriverLicenseForTheFirstTIme {
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
      this.tbNotes = new System.Windows.Forms.TextBox();
      this.cntrlVisionTestAppointment1 = new DVLD_Form.Controls.cntrlVisionTestAppointment();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbNotes
      // 
      this.tbNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbNotes.Location = new System.Drawing.Point(6, 19);
      this.tbNotes.Multiline = true;
      this.tbNotes.Name = "tbNotes";
      this.tbNotes.Size = new System.Drawing.Size(480, 66);
      this.tbNotes.TabIndex = 0;
      // 
      // cntrlVisionTestAppointment1
      // 
      this.cntrlVisionTestAppointment1.Location = new System.Drawing.Point(12, 45);
      this.cntrlVisionTestAppointment1.Name = "cntrlVisionTestAppointment1";
      this.cntrlVisionTestAppointment1.Size = new System.Drawing.Size(498, 263);
      this.cntrlVisionTestAppointment1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(389, 33);
      this.label1.TabIndex = 3;
      this.label1.Text = "Issue Driving License First Time";
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button2.BackgroundImage = global::DVLD_Form.Properties.Resources.calendar_add_on_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button2.Location = new System.Drawing.Point(474, 416);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(30, 30);
      this.button2.TabIndex = 17;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tbNotes);
      this.groupBox1.Location = new System.Drawing.Point(12, 310);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(492, 100);
      this.groupBox1.TabIndex = 18;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Notes";
      // 
      // IssueDriverLicenseForTheFirstTIme
      // 
      this.AcceptButton = this.button2;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(522, 456);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cntrlVisionTestAppointment1);
      this.Name = "IssueDriverLicenseForTheFirstTIme";
      this.ShowIcon = false;
      this.Text = "Issue Driver License For The First TIme";
      this.Load += new System.EventHandler(this.IssueDriverLicenseForTheFirstTIme_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbNotes;
    private Controls.cntrlVisionTestAppointment cntrlVisionTestAppointment1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}