namespace DVLD_Form.Controls
{
    partial class cntrlSearchBox
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
      this.label2 = new System.Windows.Forms.Label();
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.cbFilter = new System.Windows.Forms.ComboBox();
      this.btSearch = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(3, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "Filter By:";
      // 
      // tbFilter
      // 
      this.tbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbFilter.Font = new System.Drawing.Font("Tahoma", 12F);
      this.tbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbFilter.Location = new System.Drawing.Point(182, 7);
      this.tbFilter.Name = "tbFilter";
      this.tbFilter.Size = new System.Drawing.Size(97, 27);
      this.tbFilter.TabIndex = 17;
      this.tbFilter.Visible = false;
      this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
      // 
      // cbFilter
      // 
      this.cbFilter.Font = new System.Drawing.Font("Tahoma", 12F);
      this.cbFilter.FormattingEnabled = true;
      this.cbFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo"});
      this.cbFilter.Location = new System.Drawing.Point(65, 7);
      this.cbFilter.Name = "cbFilter";
      this.cbFilter.Size = new System.Drawing.Size(109, 27);
      this.cbFilter.TabIndex = 16;
      this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
      // 
      // btSearch
      // 
      this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.btSearch.BackgroundImage = global::DVLD_Form.Properties.Resources.search_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btSearch.Location = new System.Drawing.Point(285, 6);
      this.btSearch.Name = "btSearch";
      this.btSearch.Size = new System.Drawing.Size(30, 30);
      this.btSearch.TabIndex = 111;
      this.btSearch.UseVisualStyleBackColor = false;
      this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
      // 
      // cntrlSearchBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btSearch);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbFilter);
      this.Controls.Add(this.cbFilter);
      this.Name = "cntrlSearchBox";
      this.Size = new System.Drawing.Size(322, 39);
      this.Load += new System.EventHandler(this.cntrlSearchBox_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
    private System.Windows.Forms.Button btSearch;
  }
}
