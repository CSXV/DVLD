namespace DVLD_Form.Forms.Tests
{
    partial class frmTestAppointment
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.lbHeader = new System.Windows.Forms.Label();
      this.cntrlVisionTestAppointment1 = new DVLD_Form.Controls.cntrlVisionTestAppointment();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dataGridView1.Location = new System.Drawing.Point(0, 355);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.Size = new System.Drawing.Size(517, 164);
      this.dataGridView1.TabIndex = 1;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeTestToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
      this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
      // 
      // takeTestToolStripMenuItem
      // 
      this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
      this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.takeTestToolStripMenuItem.Text = "Take Test";
      this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(9, 331);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Appointments";
      // 
      // lbHeader
      // 
      this.lbHeader.AutoSize = true;
      this.lbHeader.Font = new System.Drawing.Font("Tahoma", 20F);
      this.lbHeader.Location = new System.Drawing.Point(12, 9);
      this.lbHeader.Name = "lbHeader";
      this.lbHeader.Size = new System.Drawing.Size(144, 33);
      this.lbHeader.TabIndex = 4;
      this.lbHeader.Text = "Vision Test";
      // 
      // cntrlVisionTestAppointment1
      // 
      this.cntrlVisionTestAppointment1.Location = new System.Drawing.Point(12, 45);
      this.cntrlVisionTestAppointment1.Name = "cntrlVisionTestAppointment1";
      this.cntrlVisionTestAppointment1.Size = new System.Drawing.Size(497, 263);
      this.cntrlVisionTestAppointment1.TabIndex = 0;
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.button2.BackgroundImage = global::DVLD_Form.Properties.Resources.calendar_add_on_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.button2.Location = new System.Drawing.Point(475, 314);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(30, 30);
      this.button2.TabIndex = 16;
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // TestAppointment
      // 
      this.AcceptButton = this.button2;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(517, 519);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.lbHeader);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.cntrlVisionTestAppointment1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "TestAppointment";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Vision Test Appointment";
      this.Load += new System.EventHandler(this.VisionTestAppointment_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Controls.cntrlVisionTestAppointment cntrlVisionTestAppointment1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    private System.Windows.Forms.Label lbHeader;
    private System.Windows.Forms.Button button2;
  }
}