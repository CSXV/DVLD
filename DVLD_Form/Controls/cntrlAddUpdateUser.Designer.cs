namespace DVLD_Form.Controls
{
    partial class cntrlAddUpdateUser
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tbPersonInfo = new System.Windows.Forms.TabPage();
      this.cntrlSearchBox1 = new DVLD_Form.Controls.cntrlSearchBox();
      this.cntrlPersonInfo1 = new DVLD_Form.Controls.cntrlPersonInfo();
      this.tbLogInInfo = new System.Windows.Forms.TabPage();
      this.cntrlNewUser1 = new DVLD_Form.Controls.cntrlNewUser();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.lbHeader = new System.Windows.Forms.Label();
      this.btNext = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tbPersonInfo.SuspendLayout();
      this.tbLogInInfo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tbPersonInfo);
      this.tabControl1.Controls.Add(this.tbLogInInfo);
      this.tabControl1.Location = new System.Drawing.Point(3, 66);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(338, 621);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      // 
      // tbPersonInfo
      // 
      this.tbPersonInfo.Controls.Add(this.btNext);
      this.tbPersonInfo.Controls.Add(this.cntrlSearchBox1);
      this.tbPersonInfo.Controls.Add(this.cntrlPersonInfo1);
      this.tbPersonInfo.Location = new System.Drawing.Point(4, 22);
      this.tbPersonInfo.Name = "tbPersonInfo";
      this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
      this.tbPersonInfo.Size = new System.Drawing.Size(330, 595);
      this.tbPersonInfo.TabIndex = 0;
      this.tbPersonInfo.Text = "Person Info";
      this.tbPersonInfo.UseVisualStyleBackColor = true;
      // 
      // cntrlSearchBox1
      // 
      this.cntrlSearchBox1.Location = new System.Drawing.Point(6, 3);
      this.cntrlSearchBox1.Name = "cntrlSearchBox1";
      this.cntrlSearchBox1.Size = new System.Drawing.Size(322, 39);
      this.cntrlSearchBox1.TabIndex = 17;
      // 
      // cntrlPersonInfo1
      // 
      this.cntrlPersonInfo1.Location = new System.Drawing.Point(6, 48);
      this.cntrlPersonInfo1.Name = "cntrlPersonInfo1";
      this.cntrlPersonInfo1.Size = new System.Drawing.Size(193, 539);
      this.cntrlPersonInfo1.TabIndex = 0;
      // 
      // tbLogInInfo
      // 
      this.tbLogInInfo.Controls.Add(this.cntrlNewUser1);
      this.tbLogInInfo.Location = new System.Drawing.Point(4, 22);
      this.tbLogInInfo.Name = "tbLogInInfo";
      this.tbLogInInfo.Padding = new System.Windows.Forms.Padding(3);
      this.tbLogInInfo.Size = new System.Drawing.Size(330, 595);
      this.tbLogInInfo.TabIndex = 1;
      this.tbLogInInfo.Text = "Login Info";
      this.tbLogInInfo.UseVisualStyleBackColor = true;
      // 
      // cntrlNewUser1
      // 
      this.cntrlNewUser1.Location = new System.Drawing.Point(6, 6);
      this.cntrlNewUser1.Name = "cntrlNewUser1";
      this.cntrlNewUser1.Size = new System.Drawing.Size(225, 135);
      this.cntrlNewUser1.TabIndex = 0;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // lbHeader
      // 
      this.lbHeader.AutoSize = true;
      this.lbHeader.Font = new System.Drawing.Font("Tahoma", 20F);
      this.lbHeader.Location = new System.Drawing.Point(7, 9);
      this.lbHeader.Name = "lbHeader";
      this.lbHeader.Size = new System.Drawing.Size(123, 33);
      this.lbHeader.TabIndex = 1;
      this.lbHeader.Text = "Add User";
      // 
      // btNext
      // 
      this.btNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btNext.BackgroundImage = global::DVLD_Form.Properties.Resources.arrow_forward_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
      this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btNext.Location = new System.Drawing.Point(290, 52);
      this.btNext.Name = "btNext";
      this.btNext.Size = new System.Drawing.Size(30, 30);
      this.btNext.TabIndex = 29;
      this.btNext.UseVisualStyleBackColor = false;
      this.btNext.Click += new System.EventHandler(this.btNext_Click);
      // 
      // cntrlAddUpdateUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbHeader);
      this.Controls.Add(this.tabControl1);
      this.Name = "cntrlAddUpdateUser";
      this.Size = new System.Drawing.Size(344, 690);
      this.Load += new System.EventHandler(this.cntrlAddUpdateUser_Load);
      this.tabControl1.ResumeLayout(false);
      this.tbPersonInfo.ResumeLayout(false);
      this.tbLogInInfo.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private cntrlPersonInfo cntrlPersonInfo1;
        private System.Windows.Forms.TabPage tbLogInInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private cntrlSearchBox cntrlSearchBox1;
        private cntrlNewUser cntrlNewUser1;
        private System.Windows.Forms.Label lbHeader;
    private System.Windows.Forms.Button btNext;
  }
}
