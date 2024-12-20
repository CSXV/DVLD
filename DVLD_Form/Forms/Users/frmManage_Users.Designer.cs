namespace DVLD_Form.Forms
{
    partial class frmManage_Users
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
      this.components = new System.ComponentModel.Container();
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.cbFilter = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dgvUsers = new System.Windows.Forms.DataGridView();
      this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsmiShowInfo = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
      this.label2 = new System.Windows.Forms.Label();
      this.cbIsActive = new System.Windows.Forms.ComboBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
      this.cmsUsers.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbFilter
      // 
      this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.tbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbFilter.Location = new System.Drawing.Point(243, 56);
      this.tbFilter.Name = "tbFilter";
      this.tbFilter.Size = new System.Drawing.Size(167, 20);
      this.tbFilter.TabIndex = 10;
      this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
      this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
      // 
      // cbFilter
      // 
      this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.cbFilter.FormattingEnabled = true;
      this.cbFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "User Name",
            "IsActive",
            "Full Name"});
      this.cbFilter.Location = new System.Drawing.Point(69, 56);
      this.cbFilter.Name = "cbFilter";
      this.cbFilter.Size = new System.Drawing.Size(167, 21);
      this.cbFilter.TabIndex = 9;
      this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(182, 33);
      this.label1.TabIndex = 8;
      this.label1.Text = "Manage Users";
      // 
      // dgvUsers
      // 
      this.dgvUsers.AllowUserToAddRows = false;
      this.dgvUsers.AllowUserToDeleteRows = false;
      this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvUsers.ContextMenuStrip = this.cmsUsers;
      this.dgvUsers.Location = new System.Drawing.Point(0, 83);
      this.dgvUsers.Name = "dgvUsers";
      this.dgvUsers.ReadOnly = true;
      this.dgvUsers.Size = new System.Drawing.Size(844, 344);
      this.dgvUsers.TabIndex = 7;
      // 
      // cmsUsers
      // 
      this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowInfo,
            this.toolStripSeparator1,
            this.tsmiAdd,
            this.tsmiDelete,
            this.tsmiEdit,
            this.tsmiChangePassword});
      this.cmsUsers.Name = "cmsUsers";
      this.cmsUsers.Size = new System.Drawing.Size(169, 120);
      // 
      // tsmiShowInfo
      // 
      this.tsmiShowInfo.Image = global::DVLD_Form.Properties.Resources.info;
      this.tsmiShowInfo.Name = "tsmiShowInfo";
      this.tsmiShowInfo.Size = new System.Drawing.Size(168, 22);
      this.tsmiShowInfo.Text = "Show Info";
      this.tsmiShowInfo.Click += new System.EventHandler(this.tsmiShowInfo_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
      // 
      // tsmiAdd
      // 
      this.tsmiAdd.Image = global::DVLD_Form.Properties.Resources.add;
      this.tsmiAdd.Name = "tsmiAdd";
      this.tsmiAdd.Size = new System.Drawing.Size(168, 22);
      this.tsmiAdd.Text = "Add";
      this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
      // 
      // tsmiDelete
      // 
      this.tsmiDelete.Image = global::DVLD_Form.Properties.Resources.delete;
      this.tsmiDelete.Name = "tsmiDelete";
      this.tsmiDelete.Size = new System.Drawing.Size(168, 22);
      this.tsmiDelete.Text = "Delete";
      this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
      // 
      // tsmiEdit
      // 
      this.tsmiEdit.Image = global::DVLD_Form.Properties.Resources.edit;
      this.tsmiEdit.Name = "tsmiEdit";
      this.tsmiEdit.Size = new System.Drawing.Size(168, 22);
      this.tsmiEdit.Text = "Edit";
      this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
      // 
      // tsmiChangePassword
      // 
      this.tsmiChangePassword.Image = global::DVLD_Form.Properties.Resources.password;
      this.tsmiChangePassword.Name = "tsmiChangePassword";
      this.tsmiChangePassword.Size = new System.Drawing.Size(168, 22);
      this.tsmiChangePassword.Text = "Change Password";
      this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Filter By:";
      // 
      // cbIsActive
      // 
      this.cbIsActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.cbIsActive.FormattingEnabled = true;
      this.cbIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
      this.cbIsActive.Location = new System.Drawing.Point(243, 56);
      this.cbIsActive.Name = "cbIsActive";
      this.cbIsActive.Size = new System.Drawing.Size(86, 21);
      this.cbIsActive.TabIndex = 13;
      this.cbIsActive.Visible = false;
      this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button2.BackgroundImage = global::DVLD_Form.Properties.Resources.refresh_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button2.Location = new System.Drawing.Point(756, 42);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(35, 35);
      this.button2.TabIndex = 15;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button1.BackgroundImage = global::DVLD_Form.Properties.Resources.person_add_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button1.Location = new System.Drawing.Point(797, 42);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(35, 35);
      this.button1.TabIndex = 14;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // UsersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(844, 427);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.cbIsActive);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbFilter);
      this.Controls.Add(this.cbFilter);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgvUsers);
      this.Name = "UsersForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Manage Users";
      this.Load += new System.EventHandler(this.UsersForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
      this.cmsUsers.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ComboBox cbIsActive;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}