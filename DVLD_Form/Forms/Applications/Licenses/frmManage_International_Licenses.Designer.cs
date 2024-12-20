namespace DVLD_Form.Forms.Applications {
  partial class frmManage_International_Licenses {
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
      this.components = new System.ComponentModel.Container();
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.cbFilter = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cbIsActive = new System.Windows.Forms.ComboBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbFilter
      // 
      this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.tbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbFilter.Location = new System.Drawing.Point(235, 87);
      this.tbFilter.Name = "tbFilter";
      this.tbFilter.Size = new System.Drawing.Size(167, 20);
      this.tbFilter.TabIndex = 17;
      this.tbFilter.Visible = false;
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
            "InternationalLicenseID",
            "ApplicationID",
            "DriverID",
            "IssuedUsingLocalLicenseID",
            "IsActive",
            "CreatedByUserID"});
      this.cbFilter.Location = new System.Drawing.Point(61, 87);
      this.cbFilter.Name = "cbFilter";
      this.cbFilter.Size = new System.Drawing.Size(167, 21);
      this.cbFilter.TabIndex = 16;
      this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 15;
      this.label2.Text = "Filter By:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(523, 33);
      this.label1.TabIndex = 14;
      this.label1.Text = "Manage International Licenses Applications";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
      this.dataGridView1.Location = new System.Drawing.Point(1, 114);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(1207, 378);
      this.dataGridView1.TabIndex = 13;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(221, 70);
      // 
      // showPersonDetailsToolStripMenuItem
      // 
      this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
      this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
      this.showPersonDetailsToolStripMenuItem.Text = "Show person details";
      this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
      // 
      // showLicenseDetailsToolStripMenuItem
      // 
      this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
      this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
      this.showLicenseDetailsToolStripMenuItem.Text = "Show license details";
      this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
      // 
      // showPersonLicenseHistoryToolStripMenuItem
      // 
      this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
      this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
      this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show person license history";
      this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
      // 
      // cbIsActive
      // 
      this.cbIsActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.cbIsActive.FormattingEnabled = true;
      this.cbIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
      this.cbIsActive.Location = new System.Drawing.Point(235, 86);
      this.cbIsActive.Name = "cbIsActive";
      this.cbIsActive.Size = new System.Drawing.Size(86, 21);
      this.cbIsActive.TabIndex = 19;
      this.cbIsActive.Visible = false;
      this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button2.BackgroundImage = global::DVLD_Form.Properties.Resources.refresh_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button2.Location = new System.Drawing.Point(1120, 68);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(35, 35);
      this.button2.TabIndex = 22;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button1.BackgroundImage = global::DVLD_Form.Properties.Resources.docs_add_on_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button1.Location = new System.Drawing.Point(1161, 68);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(35, 35);
      this.button1.TabIndex = 21;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // InternationalLicensesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(1208, 493);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.cbIsActive);
      this.Controls.Add(this.tbFilter);
      this.Controls.Add(this.cbFilter);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "InternationalLicensesForm";
      this.ShowIcon = false;
      this.Text = "International Licenses Form";
      this.Load += new System.EventHandler(this.InternationalLicensesForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox tbFilter;
    private System.Windows.Forms.ComboBox cbFilter;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ComboBox cbIsActive;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
  }
}