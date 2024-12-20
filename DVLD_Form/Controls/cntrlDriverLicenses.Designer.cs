namespace DVLD_Form.Controls {
  partial class cntrlDriverLicenses {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dgvLocal = new System.Windows.Forms.DataGridView();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dgvInternational = new System.Windows.Forms.DataGridView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(3, 3);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(727, 414);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dgvLocal);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(719, 388);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Local";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // dgvLocal
      // 
      this.dgvLocal.AllowUserToAddRows = false;
      this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvLocal.ContextMenuStrip = this.contextMenuStrip1;
      this.dgvLocal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvLocal.Location = new System.Drawing.Point(3, 3);
      this.dgvLocal.Name = "dgvLocal";
      this.dgvLocal.ReadOnly = true;
      this.dgvLocal.Size = new System.Drawing.Size(713, 382);
      this.dgvLocal.TabIndex = 0;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dgvInternational);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(719, 388);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "International";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dgvInternational
      // 
      this.dgvInternational.AllowUserToAddRows = false;
      this.dgvInternational.AllowUserToDeleteRows = false;
      this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvInternational.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvInternational.Location = new System.Drawing.Point(3, 3);
      this.dgvInternational.Name = "dgvInternational";
      this.dgvInternational.ReadOnly = true;
      this.dgvInternational.Size = new System.Drawing.Size(713, 382);
      this.dgvInternational.TabIndex = 0;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonLicenseHistoryToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
      // 
      // showPersonLicenseHistoryToolStripMenuItem
      // 
      this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Form.Properties.Resources.info;
      this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
      this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show license info";
      this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
      // 
      // cntrlDriverLicenses
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tabControl1);
      this.Name = "cntrlDriverLicenses";
      this.Size = new System.Drawing.Size(734, 420);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView dgvLocal;
    private System.Windows.Forms.DataGridView dgvInternational;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
  }
}
