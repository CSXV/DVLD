namespace DVLD_Form.Forms.Tests
{
    partial class frmScheduleTestForm
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
      this.cntrlScheduleTest1 = new DVLD_Form.Controls.cntrlScheduleTest();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cntrlScheduleTest1
      // 
      this.cntrlScheduleTest1.Location = new System.Drawing.Point(12, 45);
      this.cntrlScheduleTest1.Name = "cntrlScheduleTest1";
      this.cntrlScheduleTest1.Size = new System.Drawing.Size(311, 338);
      this.cntrlScheduleTest1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(180, 33);
      this.label1.TabIndex = 1;
      this.label1.Text = "Schedule Test";
      // 
      // ScheduleTestForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(333, 391);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cntrlScheduleTest1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "ScheduleTestForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Schedule Test";
      this.Load += new System.EventHandler(this.ScheduleTestForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Controls.cntrlScheduleTest cntrlScheduleTest1;
        private System.Windows.Forms.Label label1;
    }
}