namespace DVLD_Form.Forms.Tests {
  partial class frmTakeTestForm {
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
      this.rbFail = new System.Windows.Forms.RadioButton();
      this.rbPass = new System.Windows.Forms.RadioButton();
      this.tbNotes = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btSave = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // rbFail
      // 
      this.rbFail.AutoSize = true;
      this.rbFail.Location = new System.Drawing.Point(59, 18);
      this.rbFail.Name = "rbFail";
      this.rbFail.Size = new System.Drawing.Size(41, 17);
      this.rbFail.TabIndex = 0;
      this.rbFail.Text = "Fail";
      this.rbFail.UseVisualStyleBackColor = true;
      this.rbFail.Click += new System.EventHandler(this.rbFail_Click);
      // 
      // rbPass
      // 
      this.rbPass.AutoSize = true;
      this.rbPass.Checked = true;
      this.rbPass.Location = new System.Drawing.Point(6, 18);
      this.rbPass.Name = "rbPass";
      this.rbPass.Size = new System.Drawing.Size(47, 17);
      this.rbPass.TabIndex = 1;
      this.rbPass.TabStop = true;
      this.rbPass.Text = "Pass";
      this.rbPass.UseVisualStyleBackColor = true;
      this.rbPass.Click += new System.EventHandler(this.rbPass_Click);
      // 
      // tbNotes
      // 
      this.tbNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbNotes.Location = new System.Drawing.Point(6, 19);
      this.tbNotes.Multiline = true;
      this.tbNotes.Name = "tbNotes";
      this.tbNotes.Size = new System.Drawing.Size(269, 42);
      this.tbNotes.TabIndex = 2;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tbNotes);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(282, 70);
      this.groupBox1.TabIndex = 21;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Notes";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rbPass);
      this.groupBox2.Controls.Add(this.rbFail);
      this.groupBox2.Location = new System.Drawing.Point(12, 88);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(246, 41);
      this.groupBox2.TabIndex = 22;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Result";
      // 
      // btSave
      // 
      this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btSave.BackgroundImage = global::DVLD_Form.Properties.Resources.check_circle_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
      this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btSave.Location = new System.Drawing.Point(264, 98);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(30, 30);
      this.btSave.TabIndex = 23;
      this.btSave.UseVisualStyleBackColor = false;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // TakeTestForm
      // 
      this.AcceptButton = this.btSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(306, 140);
      this.Controls.Add(this.btSave);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "TakeTestForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Take Test";
      this.Load += new System.EventHandler(this.TakeTestForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RadioButton rbFail;
    private System.Windows.Forms.RadioButton rbPass;
    private System.Windows.Forms.TextBox tbNotes;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btSave;
  }
}