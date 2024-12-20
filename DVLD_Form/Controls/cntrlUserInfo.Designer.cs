namespace DVLD_Form.Controls
{
    partial class cntrlUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lbIsActive = new System.Windows.Forms.Label();
      this.lbUserName = new System.Windows.Forms.Label();
      this.lbUserID = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(126, 33);
      this.label1.TabIndex = 0;
      this.label1.Text = "User Info";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(5, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "UserID";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(5, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "User Name";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(5, 83);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Is Active";
      // 
      // lbIsActive
      // 
      this.lbIsActive.AutoSize = true;
      this.lbIsActive.Location = new System.Drawing.Point(79, 83);
      this.lbIsActive.Name = "lbIsActive";
      this.lbIsActive.Size = new System.Drawing.Size(25, 13);
      this.lbIsActive.TabIndex = 7;
      this.lbIsActive.Text = "N/A";
      // 
      // lbUserName
      // 
      this.lbUserName.AutoSize = true;
      this.lbUserName.Location = new System.Drawing.Point(79, 61);
      this.lbUserName.Name = "lbUserName";
      this.lbUserName.Size = new System.Drawing.Size(25, 13);
      this.lbUserName.TabIndex = 6;
      this.lbUserName.Text = "N/A";
      // 
      // lbUserID
      // 
      this.lbUserID.AutoSize = true;
      this.lbUserID.Location = new System.Drawing.Point(79, 39);
      this.lbUserID.Name = "lbUserID";
      this.lbUserID.Size = new System.Drawing.Size(25, 13);
      this.lbUserID.TabIndex = 5;
      this.lbUserID.Text = "N/A";
      // 
      // cntrlUserInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbIsActive);
      this.Controls.Add(this.lbUserName);
      this.Controls.Add(this.lbUserID);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "cntrlUserInfo";
      this.Size = new System.Drawing.Size(175, 108);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserID;
    }
}
