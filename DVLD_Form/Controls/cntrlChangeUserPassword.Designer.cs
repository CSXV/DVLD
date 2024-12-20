namespace DVLD_Form.Controls
{
    partial class cntrlChangeUserPassword
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
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tbCurrentPassword = new System.Windows.Forms.TextBox();
      this.tbNewPassword = new System.Windows.Forms.TextBox();
      this.tbConfirmPassword = new System.Windows.Forms.TextBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.cntrlPersonInfo1 = new DVLD_Form.Controls.cntrlPersonInfo();
      this.cntrlUserInfo1 = new DVLD_Form.Controls.cntrlUserInfo();
      this.btSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(226, 131);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(107, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Current Password";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(226, 157);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "New Password";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(226, 183);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(108, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Confirm Password";
      // 
      // tbCurrentPassword
      // 
      this.tbCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbCurrentPassword.Location = new System.Drawing.Point(340, 128);
      this.tbCurrentPassword.Name = "tbCurrentPassword";
      this.tbCurrentPassword.PasswordChar = '*';
      this.tbCurrentPassword.Size = new System.Drawing.Size(126, 20);
      this.tbCurrentPassword.TabIndex = 5;
      this.tbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPassword_Validating);
      // 
      // tbNewPassword
      // 
      this.tbNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbNewPassword.Location = new System.Drawing.Point(340, 154);
      this.tbNewPassword.Name = "tbNewPassword";
      this.tbNewPassword.PasswordChar = '*';
      this.tbNewPassword.Size = new System.Drawing.Size(126, 20);
      this.tbNewPassword.TabIndex = 6;
      // 
      // tbConfirmPassword
      // 
      this.tbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbConfirmPassword.Location = new System.Drawing.Point(340, 180);
      this.tbConfirmPassword.Name = "tbConfirmPassword";
      this.tbConfirmPassword.PasswordChar = '*';
      this.tbConfirmPassword.Size = new System.Drawing.Size(126, 20);
      this.tbConfirmPassword.TabIndex = 7;
      this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // cntrlPersonInfo1
      // 
      this.cntrlPersonInfo1.Location = new System.Drawing.Point(0, 0);
      this.cntrlPersonInfo1.Name = "cntrlPersonInfo1";
      this.cntrlPersonInfo1.Size = new System.Drawing.Size(193, 539);
      this.cntrlPersonInfo1.TabIndex = 1;
      // 
      // cntrlUserInfo1
      // 
      this.cntrlUserInfo1.Location = new System.Drawing.Point(219, 3);
      this.cntrlUserInfo1.Name = "cntrlUserInfo1";
      this.cntrlUserInfo1.Size = new System.Drawing.Size(234, 107);
      this.cntrlUserInfo1.TabIndex = 0;
      // 
      // btSave
      // 
      this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btSave.BackgroundImage = global::DVLD_Form.Properties.Resources.check_circle_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
      this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btSave.Location = new System.Drawing.Point(436, 206);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(30, 30);
      this.btSave.TabIndex = 25;
      this.btSave.UseVisualStyleBackColor = false;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // cntrlChangeUserPassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btSave);
      this.Controls.Add(this.tbConfirmPassword);
      this.Controls.Add(this.tbNewPassword);
      this.Controls.Add(this.tbCurrentPassword);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cntrlPersonInfo1);
      this.Controls.Add(this.cntrlUserInfo1);
      this.Name = "cntrlChangeUserPassword";
      this.Size = new System.Drawing.Size(479, 543);
      this.Load += new System.EventHandler(this.cntrlChangeUserPassword_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private cntrlUserInfo cntrlUserInfo1;
        private cntrlPersonInfo cntrlPersonInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Button btSave;
  }
}
