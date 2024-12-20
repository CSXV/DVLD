namespace DVLD_Form
{
    partial class frmLoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.tbUser = new System.Windows.Forms.TextBox();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.pbCancelPassword = new System.Windows.Forms.PictureBox();
      this.pbCancelUserName = new System.Windows.Forms.PictureBox();
      this.pbPassword = new System.Windows.Forms.PictureBox();
      this.pbPerson = new System.Windows.Forms.PictureBox();
      this.cbRememberUser = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.pbCancelPassword)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbCancelUserName)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
      this.SuspendLayout();
      // 
      // tbUser
      // 
      this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbUser.Font = new System.Drawing.Font("Roboto", 16F);
      this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
      this.tbUser.Location = new System.Drawing.Point(113, 163);
      this.tbUser.Margin = new System.Windows.Forms.Padding(12, 16, 12, 16);
      this.tbUser.Name = "tbUser";
      this.tbUser.Size = new System.Drawing.Size(321, 33);
      this.tbUser.TabIndex = 1;
      this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
      this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
      // 
      // tbPassword
      // 
      this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbPassword.Font = new System.Drawing.Font("Roboto", 16F);
      this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
      this.tbPassword.Location = new System.Drawing.Point(113, 202);
      this.tbPassword.Margin = new System.Windows.Forms.Padding(12, 16, 12, 16);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(321, 33);
      this.tbPassword.TabIndex = 2;
      this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(242, 404);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(63, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Version 1.0";
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Roboto", 57F);
      this.label1.Location = new System.Drawing.Point(157, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(227, 91);
      this.label1.TabIndex = 8;
      this.label1.Text = "DVLD";
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Roboto", 14F);
      this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button1.Location = new System.Drawing.Point(113, 281);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(321, 33);
      this.button1.TabIndex = 4;
      this.button1.Text = "Login";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // pbCancelPassword
      // 
      this.pbCancelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pbCancelPassword.BackColor = System.Drawing.Color.Transparent;
      this.pbCancelPassword.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pbCancelPassword.Image = global::DVLD_Form.Properties.Resources.cancel_16dp_49454F_FILL0_wght400_GRAD0_opsz20;
      this.pbCancelPassword.Location = new System.Drawing.Point(449, 202);
      this.pbCancelPassword.Name = "pbCancelPassword";
      this.pbCancelPassword.Size = new System.Drawing.Size(33, 33);
      this.pbCancelPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbCancelPassword.TabIndex = 9;
      this.pbCancelPassword.TabStop = false;
      this.pbCancelPassword.Visible = false;
      this.pbCancelPassword.Click += new System.EventHandler(this.pbCancelPassword_Click);
      // 
      // pbCancelUserName
      // 
      this.pbCancelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pbCancelUserName.BackColor = System.Drawing.Color.Transparent;
      this.pbCancelUserName.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pbCancelUserName.Image = global::DVLD_Form.Properties.Resources.cancel_16dp_49454F_FILL0_wght400_GRAD0_opsz20;
      this.pbCancelUserName.Location = new System.Drawing.Point(449, 163);
      this.pbCancelUserName.Name = "pbCancelUserName";
      this.pbCancelUserName.Size = new System.Drawing.Size(33, 33);
      this.pbCancelUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbCancelUserName.TabIndex = 9;
      this.pbCancelUserName.TabStop = false;
      this.pbCancelUserName.Visible = false;
      this.pbCancelUserName.Click += new System.EventHandler(this.pbCancelUserName_Click);
      // 
      // pbPassword
      // 
      this.pbPassword.BackColor = System.Drawing.Color.Transparent;
      this.pbPassword.Image = global::DVLD_Form.Properties.Resources.password_16dp_49454F_FILL0_wght400_GRAD0_opsz20;
      this.pbPassword.Location = new System.Drawing.Point(65, 163);
      this.pbPassword.Name = "pbPassword";
      this.pbPassword.Size = new System.Drawing.Size(33, 33);
      this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbPassword.TabIndex = 3;
      this.pbPassword.TabStop = false;
      // 
      // pbPerson
      // 
      this.pbPerson.BackColor = System.Drawing.Color.Transparent;
      this.pbPerson.Image = global::DVLD_Form.Properties.Resources.account_circle_16dp_49454F_FILL0_wght400_GRAD0_opsz20;
      this.pbPerson.Location = new System.Drawing.Point(65, 202);
      this.pbPerson.Name = "pbPerson";
      this.pbPerson.Size = new System.Drawing.Size(33, 33);
      this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbPerson.TabIndex = 2;
      this.pbPerson.TabStop = false;
      // 
      // cbRememberUser
      // 
      this.cbRememberUser.AutoSize = true;
      this.cbRememberUser.Font = new System.Drawing.Font("Roboto", 16F);
      this.cbRememberUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
      this.cbRememberUser.Location = new System.Drawing.Point(113, 244);
      this.cbRememberUser.Name = "cbRememberUser";
      this.cbRememberUser.Size = new System.Drawing.Size(174, 31);
      this.cbRememberUser.TabIndex = 3;
      this.cbRememberUser.Text = "Remember Me";
      this.cbRememberUser.UseVisualStyleBackColor = true;
      // 
      // frmLoginForm
      // 
      this.AcceptButton = this.button1;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(546, 426);
      this.Controls.Add(this.cbRememberUser);
      this.Controls.Add(this.pbCancelPassword);
      this.Controls.Add(this.pbCancelUserName);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbPassword);
      this.Controls.Add(this.tbUser);
      this.Controls.Add(this.pbPassword);
      this.Controls.Add(this.pbPerson);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "frmLoginForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login Screen";
      this.Load += new System.EventHandler(this.frmLoginForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbCancelPassword)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbCancelUserName)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pbCancelUserName;
    private System.Windows.Forms.PictureBox pbCancelPassword;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox cbRememberUser;
  }
}