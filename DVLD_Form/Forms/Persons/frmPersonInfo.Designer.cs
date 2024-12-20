namespace DVLD_Form.Forms {
    partial class frmPersonInfo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
      this.cntrlPersonInfo1 = new DVLD_Form.Controls.cntrlPersonInfo();
      this.SuspendLayout();
      // 
      // cntrlPersonInfo1
      // 
      this.cntrlPersonInfo1.Location = new System.Drawing.Point(1, 1);
      this.cntrlPersonInfo1.Name = "cntrlPersonInfo1";
      this.cntrlPersonInfo1.Size = new System.Drawing.Size(190, 539);
      this.cntrlPersonInfo1.TabIndex = 0;
      // 
      // PersonInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(192, 541);
      this.Controls.Add(this.cntrlPersonInfo1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "PersonInfo";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "User Info";
      this.ResumeLayout(false);

        }

    #endregion

    private Controls.cntrlPersonInfo cntrlPersonInfo1;
  }
}