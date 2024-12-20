namespace DVLD_Form.Controls
{
    partial class cntrlNewUser
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
      this.cbIsActive = new System.Windows.Forms.CheckBox();
      this.lbUserID = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbConfPassword = new System.Windows.Forms.TextBox();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tbUserName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.btSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // cbIsActive
      // 
      this.cbIsActive.AutoSize = true;
      this.cbIsActive.Checked = true;
      this.cbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbIsActive.Location = new System.Drawing.Point(92, 106);
      this.cbIsActive.Name = "cbIsActive";
      this.cbIsActive.Size = new System.Drawing.Size(68, 17);
      this.cbIsActive.TabIndex = 4;
      this.cbIsActive.Text = "Is Active";
      this.cbIsActive.UseVisualStyleBackColor = true;
      // 
      // lbUserID
      // 
      this.lbUserID.AutoSize = true;
      this.lbUserID.Location = new System.Drawing.Point(89, 0);
      this.lbUserID.Name = "lbUserID";
      this.lbUserID.Size = new System.Drawing.Size(25, 13);
      this.lbUserID.TabIndex = 17;
      this.lbUserID.Text = "N/A";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(3, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(46, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "UserID";
      // 
      // tbConfPassword
      // 
      this.tbConfPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbConfPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbConfPassword.Location = new System.Drawing.Point(92, 72);
      this.tbConfPassword.Name = "tbConfPassword";
      this.tbConfPassword.PasswordChar = '*';
      this.tbConfPassword.Size = new System.Drawing.Size(130, 20);
      this.tbConfPassword.TabIndex = 3;
      this.tbConfPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfPassword_Validating);
      // 
      // tbPassword
      // 
      this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbPassword.Location = new System.Drawing.Point(92, 46);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(130, 20);
      this.tbPassword.TabIndex = 2;
      this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(3, 75);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(83, 13);
      this.label5.TabIndex = 14;
      this.label5.Text = "Confirm Pass.";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(3, 25);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(68, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "User Name";
      // 
      // tbUserName
      // 
      this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbUserName.Location = new System.Drawing.Point(92, 20);
      this.tbUserName.Name = "tbUserName";
      this.tbUserName.Size = new System.Drawing.Size(130, 20);
      this.tbUserName.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(3, 50);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Password";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // btSave
      // 
      this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btSave.BackgroundImage = global::DVLD_Form.Properties.Resources.check_circle_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
      this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btSave.Location = new System.Drawing.Point(192, 98);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(30, 30);
      this.btSave.TabIndex = 25;
      this.btSave.UseVisualStyleBackColor = false;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // cntrlNewUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btSave);
      this.Controls.Add(this.cbIsActive);
      this.Controls.Add(this.lbUserID);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.tbConfPassword);
      this.Controls.Add(this.tbPassword);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbUserName);
      this.Controls.Add(this.label3);
      this.Name = "cntrlNewUser";
      this.Size = new System.Drawing.Size(225, 135);
      this.Load += new System.EventHandler(this.cntrlUserInfo_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbConfPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Button btSave;
  }
}
