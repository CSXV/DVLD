namespace DVLD_Form.Forms.Applications {
  partial class NewInternationalDrivingLicenseApplication {
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.cntrlSearchBox1 = new DVLD_Form.Controls.cntrlSearchBox();
      this.cntrlPersonInfo1 = new DVLD_Form.Controls.cntrlPersonInfo();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.cbLicenseClass = new System.Windows.Forms.ComboBox();
      this.lbCreatedBy = new System.Windows.Forms.Label();
      this.lbApplicationFees = new System.Windows.Forms.Label();
      this.lbDLA_ID = new System.Windows.Forms.Label();
      this.lbApplicationDate = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.pbNext = new System.Windows.Forms.PictureBox();
      this.pbSave = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(18, 54);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(336, 623);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.pbNext);
      this.tabPage1.Controls.Add(this.cntrlSearchBox1);
      this.tabPage1.Controls.Add(this.cntrlPersonInfo1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(328, 597);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Person Info";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // cntrlSearchBox1
      // 
      this.cntrlSearchBox1.Location = new System.Drawing.Point(3, 6);
      this.cntrlSearchBox1.Name = "cntrlSearchBox1";
      this.cntrlSearchBox1.Size = new System.Drawing.Size(322, 39);
      this.cntrlSearchBox1.TabIndex = 1;
      // 
      // cntrlPersonInfo1
      // 
      this.cntrlPersonInfo1.Location = new System.Drawing.Point(3, 51);
      this.cntrlPersonInfo1.Name = "cntrlPersonInfo1";
      this.cntrlPersonInfo1.Size = new System.Drawing.Size(193, 539);
      this.cntrlPersonInfo1.TabIndex = 0;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.pbSave);
      this.tabPage2.Controls.Add(this.cbLicenseClass);
      this.tabPage2.Controls.Add(this.lbCreatedBy);
      this.tabPage2.Controls.Add(this.lbApplicationFees);
      this.tabPage2.Controls.Add(this.lbDLA_ID);
      this.tabPage2.Controls.Add(this.lbApplicationDate);
      this.tabPage2.Controls.Add(this.label6);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.label4);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(328, 597);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Application Info";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // cbLicenseClass
      // 
      this.cbLicenseClass.FormattingEnabled = true;
      this.cbLicenseClass.Items.AddRange(new object[] {
            "Class 01 - Small Motorcycle",
            "Class 02 - Heavy Motorcyle",
            "Class 03 - Ordinary driving license",
            "Class 04 - Commercial",
            "Class 05 - Agricultural",
            "Class 06 - Small & medium bus",
            "Class 07 - Truck & heavy vehicle"});
      this.cbLicenseClass.Location = new System.Drawing.Point(123, 61);
      this.cbLicenseClass.Name = "cbLicenseClass";
      this.cbLicenseClass.Size = new System.Drawing.Size(121, 21);
      this.cbLicenseClass.TabIndex = 9;
      // 
      // lbCreatedBy
      // 
      this.lbCreatedBy.AutoSize = true;
      this.lbCreatedBy.Location = new System.Drawing.Point(120, 112);
      this.lbCreatedBy.Name = "lbCreatedBy";
      this.lbCreatedBy.Size = new System.Drawing.Size(25, 13);
      this.lbCreatedBy.TabIndex = 8;
      this.lbCreatedBy.Text = "N/A";
      // 
      // lbApplicationFees
      // 
      this.lbApplicationFees.AutoSize = true;
      this.lbApplicationFees.Location = new System.Drawing.Point(120, 88);
      this.lbApplicationFees.Name = "lbApplicationFees";
      this.lbApplicationFees.Size = new System.Drawing.Size(19, 13);
      this.lbApplicationFees.TabIndex = 7;
      this.lbApplicationFees.Tag = "15";
      this.lbApplicationFees.Text = "15";
      // 
      // lbDLA_ID
      // 
      this.lbDLA_ID.AutoSize = true;
      this.lbDLA_ID.Location = new System.Drawing.Point(120, 16);
      this.lbDLA_ID.Name = "lbDLA_ID";
      this.lbDLA_ID.Size = new System.Drawing.Size(25, 13);
      this.lbDLA_ID.TabIndex = 6;
      this.lbDLA_ID.Text = "N/A";
      // 
      // lbApplicationDate
      // 
      this.lbApplicationDate.AutoSize = true;
      this.lbApplicationDate.Location = new System.Drawing.Point(120, 40);
      this.lbApplicationDate.Name = "lbApplicationDate";
      this.lbApplicationDate.Size = new System.Drawing.Size(25, 13);
      this.lbApplicationDate.TabIndex = 5;
      this.lbApplicationDate.Text = "N/A";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(15, 112);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(69, 13);
      this.label6.TabIndex = 4;
      this.label6.Text = "Created By";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(15, 88);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(99, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Application Fees";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(15, 64);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(81, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "License Class";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(15, 40);
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
      this.label2.Size = new System.Drawing.Size(51, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "D.L.A ID";
      // 
      // pbNext
      // 
      this.pbNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbNext.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pbNext.Image = global::DVLD_Form.Properties.Resources.arrow_forward;
      this.pbNext.Location = new System.Drawing.Point(288, 55);
      this.pbNext.Name = "pbNext";
      this.pbNext.Size = new System.Drawing.Size(30, 30);
      this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbNext.TabIndex = 2;
      this.pbNext.TabStop = false;
      // 
      // pbSave
      // 
      this.pbSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pbSave.Image = global::DVLD_Form.Properties.Resources.check_circle;
      this.pbSave.Location = new System.Drawing.Point(214, 134);
      this.pbSave.Name = "pbSave";
      this.pbSave.Size = new System.Drawing.Size(30, 30);
      this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbSave.TabIndex = 10;
      this.pbSave.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(302, 33);
      this.label1.TabIndex = 2;
      this.label1.Text = "New Int. Driving License";
      // 
      // NewInternationalDrivingLicenseApplication
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 689);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "NewInternationalDrivingLicenseApplication";
      this.ShowIcon = false;
      this.Text = "New International Driving License Application";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.PictureBox pbNext;
    private Controls.cntrlSearchBox cntrlSearchBox1;
    private Controls.cntrlPersonInfo cntrlPersonInfo1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.PictureBox pbSave;
    private System.Windows.Forms.ComboBox cbLicenseClass;
    private System.Windows.Forms.Label lbCreatedBy;
    private System.Windows.Forms.Label lbApplicationFees;
    private System.Windows.Forms.Label lbDLA_ID;
    private System.Windows.Forms.Label lbApplicationDate;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}