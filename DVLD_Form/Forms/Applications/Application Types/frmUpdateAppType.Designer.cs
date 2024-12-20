namespace DVLD_Form.Forms.Applications
{
    partial class frmUpdateAppType
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
      this.label1 = new System.Windows.Forms.Label();
      this.tbTitle = new System.Windows.Forms.TextBox();
      this.tbFees = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lbID = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(303, 33);
      this.label1.TabIndex = 0;
      this.label1.Text = "Update Application Type";
      // 
      // tbTitle
      // 
      this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbTitle.Location = new System.Drawing.Point(80, 102);
      this.tbTitle.Name = "tbTitle";
      this.tbTitle.Size = new System.Drawing.Size(287, 20);
      this.tbTitle.TabIndex = 1;
      // 
      // tbFees
      // 
      this.tbFees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbFees.Location = new System.Drawing.Point(80, 129);
      this.tbFees.Name = "tbFees";
      this.tbFees.Size = new System.Drawing.Size(287, 20);
      this.tbFees.TabIndex = 2;
      this.tbFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFees_KeyPress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(44, 105);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Title";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(44, 78);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(20, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "ID";
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Location = new System.Drawing.Point(77, 78);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(25, 13);
      this.lbID.TabIndex = 5;
      this.lbID.Text = "N/A";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(41, 132);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Fees";
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::DVLD_Form.Properties.Resources.paid;
      this.pictureBox2.Location = new System.Drawing.Point(18, 128);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(20, 20);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 8;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = global::DVLD_Form.Properties.Resources.badge;
      this.pictureBox3.Location = new System.Drawing.Point(18, 76);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(20, 20);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 10;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::DVLD_Form.Properties.Resources.title;
      this.pictureBox1.Location = new System.Drawing.Point(18, 102);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(20, 20);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 7;
      this.pictureBox1.TabStop = false;
      // 
      // btSave
      // 
      this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btSave.BackgroundImage = global::DVLD_Form.Properties.Resources.check_circle_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
      this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btSave.Location = new System.Drawing.Point(337, 155);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(30, 30);
      this.btSave.TabIndex = 25;
      this.btSave.UseVisualStyleBackColor = false;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // UpdateAppType
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(388, 217);
      this.Controls.Add(this.btSave);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lbID);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbFees);
      this.Controls.Add(this.tbTitle);
      this.Controls.Add(this.label1);
      this.Name = "UpdateAppType";
      this.ShowIcon = false;
      this.Text = "Update Application Type";
      this.Load += new System.EventHandler(this.UpdateAppType_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btSave;
  }
}