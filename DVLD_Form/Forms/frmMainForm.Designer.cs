namespace DVLD_Form
{
    partial class frmMainForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.replacementForLostOrDamagedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.internationalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stmCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
      this.stiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.stiLogOut = new System.Windows.Forms.ToolStripMenuItem();
      this.btRenewLicense = new System.Windows.Forms.Button();
      this.btDetainLicense = new System.Windows.Forms.Button();
      this.btAddIntLicense = new System.Windows.Forms.Button();
      this.btAddLicense = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
      this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.menuStrip1.Font = new System.Drawing.Font("Roboto", 12F);
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 591);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
      this.menuStrip1.Size = new System.Drawing.Size(458, 115);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // applicationsToolStripMenuItem
      // 
      this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem});
      this.applicationsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
      this.applicationsToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.menu_book_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.applicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.applicationsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
      this.applicationsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 12, 0, 16);
      this.applicationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(101, 115);
      this.applicationsToolStripMenuItem.Text = "Applications";
      this.applicationsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
      this.applicationsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
      // 
      // drivingLicensesServicesToolStripMenuItem
      // 
      this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacementForLostOrDamagedLicenseToolStripMenuItem,
            this.toolStripSeparator2});
      this.drivingLicensesServicesToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.paid1;
      this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
      this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(296, 56);
      this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
      // 
      // newDrivingLicenseToolStripMenuItem
      // 
      this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
      this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.add;
      this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
      this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(414, 56);
      this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
      // 
      // localLicenseToolStripMenuItem
      // 
      this.localLicenseToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.home;
      this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
      this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(259, 56);
      this.localLicenseToolStripMenuItem.Text = "Local License";
      this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
      // 
      // internationalLicenseToolStripMenuItem
      // 
      this.internationalLicenseToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.globe;
      this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
      this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(259, 56);
      this.internationalLicenseToolStripMenuItem.Text = "International License";
      this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
      // 
      // renewDrivingLicenseToolStripMenuItem
      // 
      this.renewDrivingLicenseToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.refresh;
      this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
      this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(414, 56);
      this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
      this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
      // 
      // replacementForLostOrDamagedLicenseToolStripMenuItem
      // 
      this.replacementForLostOrDamagedLicenseToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.find_replace;
      this.replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
      this.replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new System.Drawing.Size(414, 56);
      this.replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement for Lost Or Damaged License";
      this.replacementForLostOrDamagedLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamagedLicenseToolStripMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(411, 6);
      // 
      // detainLicensesToolStripMenuItem
      // 
      this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainLicenseToolStripMenuItem});
      this.detainLicensesToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.block1;
      this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
      this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(296, 56);
      this.detainLicensesToolStripMenuItem.Text = "Detain licenses";
      // 
      // manageDetainedLicensesToolStripMenuItem
      // 
      this.manageDetainedLicensesToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.dataset;
      this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
      this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(303, 56);
      this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
      this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
      // 
      // detainLicenseToolStripMenuItem
      // 
      this.detainLicenseToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.block;
      this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
      this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(303, 56);
      this.detainLicenseToolStripMenuItem.Text = "Detain a License";
      this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
      // 
      // releaseDetainLicenseToolStripMenuItem
      // 
      this.releaseDetainLicenseToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.upgrade;
      this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
      this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(303, 56);
      this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detained License";
      this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
      // 
      // manageApplicationsToolStripMenuItem
      // 
      this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalDrivingLicenseApplicationsToolStripMenuItem});
      this.manageApplicationsToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.dataset;
      this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
      this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(296, 56);
      this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
      // 
      // localDrivingLicenseApplicationsToolStripMenuItem
      // 
      this.localDrivingLicenseApplicationsToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.home;
      this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
      this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(409, 56);
      this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
      this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
      // 
      // internationalDrivingLicenseApplicationsToolStripMenuItem
      // 
      this.internationalDrivingLicenseApplicationsToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.globe;
      this.internationalDrivingLicenseApplicationsToolStripMenuItem.Name = "internationalDrivingLicenseApplicationsToolStripMenuItem";
      this.internationalDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(409, 56);
      this.internationalDrivingLicenseApplicationsToolStripMenuItem.Text = "International  Driving License Applications";
      this.internationalDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLicenseApplicationsToolStripMenuItem_Click);
      // 
      // manageTestTypesToolStripMenuItem
      // 
      this.manageTestTypesToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.data_table;
      this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
      this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(296, 56);
      this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
      this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
      // 
      // manageApplicationTypesToolStripMenuItem
      // 
      this.manageApplicationTypesToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.apps;
      this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
      this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(296, 56);
      this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application types";
      this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
      // 
      // peopleToolStripMenuItem
      // 
      this.peopleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
      this.peopleToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.groups_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.peopleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
      this.peopleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 12, 0, 16);
      this.peopleToolStripMenuItem.ShortcutKeyDisplayString = "Ctlr+P";
      this.peopleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.peopleToolStripMenuItem.Size = new System.Drawing.Size(68, 115);
      this.peopleToolStripMenuItem.Text = "People";
      this.peopleToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
      // 
      // driversToolStripMenuItem
      // 
      this.driversToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
      this.driversToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.badge_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.driversToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
      this.driversToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 12, 0, 16);
      this.driversToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.driversToolStripMenuItem.Size = new System.Drawing.Size(68, 115);
      this.driversToolStripMenuItem.Text = "Drivers";
      this.driversToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
      // 
      // usersToolStripMenuItem
      // 
      this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
      this.usersToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.account_circle_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
      this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 12, 0, 16);
      this.usersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
      this.usersToolStripMenuItem.Size = new System.Drawing.Size(68, 115);
      this.usersToolStripMenuItem.Text = "Users";
      this.usersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
      // 
      // accountSettingsToolStripMenuItem
      // 
      this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmCurrentUserInfo,
            this.stiChangePassword,
            this.toolStripSeparator1,
            this.stiLogOut});
      this.accountSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(30)))));
      this.accountSettingsToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.settings_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.accountSettingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
      this.accountSettingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 12, 0, 16);
      this.accountSettingsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.accountSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(71, 115);
      this.accountSettingsToolStripMenuItem.Text = "Settings";
      this.accountSettingsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
      // 
      // stmCurrentUserInfo
      // 
      this.stmCurrentUserInfo.Image = global::DVLD_Form.Properties.Resources.info;
      this.stmCurrentUserInfo.Name = "stmCurrentUserInfo";
      this.stmCurrentUserInfo.Size = new System.Drawing.Size(240, 56);
      this.stmCurrentUserInfo.Text = "Current User Info";
      this.stmCurrentUserInfo.Click += new System.EventHandler(this.stmCurrentUserInfo_Click);
      // 
      // stiChangePassword
      // 
      this.stiChangePassword.Image = global::DVLD_Form.Properties.Resources.password;
      this.stiChangePassword.Name = "stiChangePassword";
      this.stiChangePassword.Size = new System.Drawing.Size(240, 56);
      this.stiChangePassword.Text = "Change Password";
      this.stiChangePassword.Click += new System.EventHandler(this.stiChangePassword_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
      // 
      // stiLogOut
      // 
      this.stiLogOut.Image = global::DVLD_Form.Properties.Resources.logout;
      this.stiLogOut.Name = "stiLogOut";
      this.stiLogOut.Size = new System.Drawing.Size(240, 56);
      this.stiLogOut.Text = "Sign Out";
      this.stiLogOut.Click += new System.EventHandler(this.stiLogOut_Click);
      // 
      // btRenewLicense
      // 
      this.btRenewLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.btRenewLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btRenewLicense.Font = new System.Drawing.Font("Roboto", 16F);
      this.btRenewLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btRenewLicense.Image = global::DVLD_Form.Properties.Resources.refresh_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.btRenewLicense.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btRenewLicense.Location = new System.Drawing.Point(235, 298);
      this.btRenewLicense.Name = "btRenewLicense";
      this.btRenewLicense.Size = new System.Drawing.Size(211, 280);
      this.btRenewLicense.TabIndex = 8;
      this.btRenewLicense.Text = "Renew a license";
      this.btRenewLicense.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btRenewLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btRenewLicense.UseVisualStyleBackColor = false;
      this.btRenewLicense.Click += new System.EventHandler(this.btRenewLicense_Click);
      // 
      // btDetainLicense
      // 
      this.btDetainLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.btDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btDetainLicense.Font = new System.Drawing.Font("Roboto", 16F);
      this.btDetainLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btDetainLicense.Image = global::DVLD_Form.Properties.Resources.block_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.btDetainLicense.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btDetainLicense.Location = new System.Drawing.Point(235, 12);
      this.btDetainLicense.Name = "btDetainLicense";
      this.btDetainLicense.Size = new System.Drawing.Size(211, 280);
      this.btDetainLicense.TabIndex = 8;
      this.btDetainLicense.Text = "Detain a license";
      this.btDetainLicense.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btDetainLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btDetainLicense.UseVisualStyleBackColor = false;
      this.btDetainLicense.Click += new System.EventHandler(this.btDetainLicense_Click);
      // 
      // btAddIntLicense
      // 
      this.btAddIntLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.btAddIntLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btAddIntLicense.Font = new System.Drawing.Font("Roboto", 16F);
      this.btAddIntLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btAddIntLicense.Image = global::DVLD_Form.Properties.Resources.globe_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.btAddIntLicense.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btAddIntLicense.Location = new System.Drawing.Point(12, 298);
      this.btAddIntLicense.Name = "btAddIntLicense";
      this.btAddIntLicense.Size = new System.Drawing.Size(217, 280);
      this.btAddIntLicense.TabIndex = 8;
      this.btAddIntLicense.Text = "New international license";
      this.btAddIntLicense.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btAddIntLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btAddIntLicense.UseVisualStyleBackColor = false;
      this.btAddIntLicense.Click += new System.EventHandler(this.btAddIntLicense_Click);
      // 
      // btAddLicense
      // 
      this.btAddLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.btAddLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btAddLicense.Font = new System.Drawing.Font("Roboto", 16F);
      this.btAddLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btAddLicense.Image = global::DVLD_Form.Properties.Resources.home_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.btAddLicense.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btAddLicense.Location = new System.Drawing.Point(12, 12);
      this.btAddLicense.Name = "btAddLicense";
      this.btAddLicense.Size = new System.Drawing.Size(217, 280);
      this.btAddLicense.TabIndex = 8;
      this.btAddLicense.Text = "New local license";
      this.btAddLicense.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btAddLicense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btAddLicense.UseVisualStyleBackColor = false;
      this.btAddLicense.Click += new System.EventHandler(this.btAddLicense_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(458, 706);
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // frmMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.ClientSize = new System.Drawing.Size(458, 706);
      this.Controls.Add(this.btRenewLicense);
      this.Controls.Add(this.btDetainLicense);
      this.Controls.Add(this.btAddIntLicense);
      this.Controls.Add(this.btAddLicense);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.pictureBox1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.IsMdiContainer = true;
      this.Name = "frmMainForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main Screen";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stmCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem stiChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stiLogOut;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenseApplicationsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
    private System.Windows.Forms.Button btAddLicense;
    private System.Windows.Forms.Button btDetainLicense;
    private System.Windows.Forms.Button btAddIntLicense;
    private System.Windows.Forms.Button btRenewLicense;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}