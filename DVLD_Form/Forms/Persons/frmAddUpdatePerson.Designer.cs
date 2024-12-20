namespace DVLD_Form.Forms {
    partial class frmAddUpdatePerson {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdatePerson));
      this.btRemove = new System.Windows.Forms.Button();
      this.btAddImage = new System.Windows.Forms.Button();
      this.btSave = new System.Windows.Forms.Button();
      this.lbText = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.tbEmail = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.tbNationalNo = new System.Windows.Forms.TextBox();
      this.lbID = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.rbFemale = new System.Windows.Forms.RadioButton();
      this.rbMale = new System.Windows.Forms.RadioButton();
      this.pbImage = new System.Windows.Forms.PictureBox();
      this.cbCountries = new System.Windows.Forms.ComboBox();
      this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbFirstName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tbAddress = new System.Windows.Forms.TextBox();
      this.tbPhone = new System.Windows.Forms.TextBox();
      this.tbLastName = new System.Windows.Forms.TextBox();
      this.tbThirdName = new System.Windows.Forms.TextBox();
      this.tbSecondName = new System.Windows.Forms.TextBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // btRemove
      // 
      this.btRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.btRemove.BackgroundImage = global::DVLD_Form.Properties.Resources.no_photography_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.btRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btRemove.Location = new System.Drawing.Point(50, 566);
      this.btRemove.Name = "btRemove";
      this.btRemove.Size = new System.Drawing.Size(30, 30);
      this.btRemove.TabIndex = 128;
      this.btRemove.UseVisualStyleBackColor = false;
      this.btRemove.Click += new System.EventHandler(this.button1_Click);
      // 
      // btAddImage
      // 
      this.btAddImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
      this.btAddImage.BackgroundImage = global::DVLD_Form.Properties.Resources.add_a_photo_16dp_4F378B_FILL0_wght400_GRAD0_opsz20;
      this.btAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btAddImage.Location = new System.Drawing.Point(14, 566);
      this.btAddImage.Name = "btAddImage";
      this.btAddImage.Size = new System.Drawing.Size(30, 30);
      this.btAddImage.TabIndex = 127;
      this.btAddImage.UseVisualStyleBackColor = false;
      this.btAddImage.Click += new System.EventHandler(this.btAddImage_Click);
      // 
      // btSave
      // 
      this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(55)))), ((int)(((byte)(139)))));
      this.btSave.BackgroundImage = global::DVLD_Form.Properties.Resources.check_circle_16dp_FFFFFF_FILL0_wght400_GRAD0_opsz20;
      this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btSave.Location = new System.Drawing.Point(178, 566);
      this.btSave.Name = "btSave";
      this.btSave.Size = new System.Drawing.Size(30, 30);
      this.btSave.TabIndex = 126;
      this.btSave.UseVisualStyleBackColor = false;
      this.btSave.Click += new System.EventHandler(this.btSave_Click);
      // 
      // lbText
      // 
      this.lbText.AutoSize = true;
      this.lbText.Font = new System.Drawing.Font("Tahoma", 20F);
      this.lbText.Location = new System.Drawing.Point(4, 5);
      this.lbText.Name = "lbText";
      this.lbText.Size = new System.Drawing.Size(150, 33);
      this.lbText.TabIndex = 125;
      this.lbText.Text = "Add Person";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label11.Location = new System.Drawing.Point(7, 287);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(37, 13);
      this.label11.TabIndex = 124;
      this.label11.Text = "Email";
      // 
      // tbEmail
      // 
      this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbEmail.Location = new System.Drawing.Point(96, 284);
      this.tbEmail.Name = "tbEmail";
      this.tbEmail.Size = new System.Drawing.Size(112, 20);
      this.tbEmail.TabIndex = 108;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label12.Location = new System.Drawing.Point(7, 183);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(73, 13);
      this.label12.TabIndex = 123;
      this.label12.Text = "National No.";
      // 
      // tbNationalNo
      // 
      this.tbNationalNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbNationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbNationalNo.Location = new System.Drawing.Point(96, 179);
      this.tbNationalNo.Name = "tbNationalNo";
      this.tbNationalNo.Size = new System.Drawing.Size(112, 20);
      this.tbNationalNo.TabIndex = 103;
      this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Location = new System.Drawing.Point(93, 53);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(25, 13);
      this.lbID.TabIndex = 122;
      this.lbID.Text = "N/A";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label10.Location = new System.Drawing.Point(7, 53);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(62, 13);
      this.label10.TabIndex = 121;
      this.label10.Text = "Person ID";
      // 
      // rbFemale
      // 
      this.rbFemale.AutoSize = true;
      this.rbFemale.Location = new System.Drawing.Point(149, 206);
      this.rbFemale.Name = "rbFemale";
      this.rbFemale.Size = new System.Drawing.Size(59, 17);
      this.rbFemale.TabIndex = 105;
      this.rbFemale.Text = "Female";
      this.rbFemale.UseVisualStyleBackColor = true;
      this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
      // 
      // rbMale
      // 
      this.rbMale.AutoSize = true;
      this.rbMale.Checked = true;
      this.rbMale.Location = new System.Drawing.Point(96, 206);
      this.rbMale.Name = "rbMale";
      this.rbMale.Size = new System.Drawing.Size(47, 17);
      this.rbMale.TabIndex = 104;
      this.rbMale.TabStop = true;
      this.rbMale.Text = "Male";
      this.rbMale.UseVisualStyleBackColor = true;
      this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
      // 
      // pbImage
      // 
      this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
      this.pbImage.Location = new System.Drawing.Point(13, 365);
      this.pbImage.Name = "pbImage";
      this.pbImage.Size = new System.Drawing.Size(195, 195);
      this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbImage.TabIndex = 120;
      this.pbImage.TabStop = false;
      // 
      // cbCountries
      // 
      this.cbCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.cbCountries.FormattingEnabled = true;
      this.cbCountries.Location = new System.Drawing.Point(96, 338);
      this.cbCountries.Name = "cbCountries";
      this.cbCountries.Size = new System.Drawing.Size(112, 21);
      this.cbCountries.TabIndex = 110;
      // 
      // dtpDateOfBirth
      // 
      this.dtpDateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.dtpDateOfBirth.Location = new System.Drawing.Point(96, 311);
      this.dtpDateOfBirth.Name = "dtpDateOfBirth";
      this.dtpDateOfBirth.Size = new System.Drawing.Size(112, 20);
      this.dtpDateOfBirth.TabIndex = 109;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label9.Location = new System.Drawing.Point(7, 339);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(52, 13);
      this.label9.TabIndex = 119;
      this.label9.Text = "Country";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label8.Location = new System.Drawing.Point(7, 313);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(79, 13);
      this.label8.TabIndex = 118;
      this.label8.Text = "Date Of Birth";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label7.Location = new System.Drawing.Point(7, 261);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(42, 13);
      this.label7.TabIndex = 117;
      this.label7.Text = "Phone";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(7, 235);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 13);
      this.label6.TabIndex = 116;
      this.label6.Text = "Address";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(7, 209);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(48, 13);
      this.label5.TabIndex = 115;
      this.label5.Text = "Gendor";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(7, 157);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 13);
      this.label4.TabIndex = 114;
      this.label4.Text = "Last Name";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(7, 131);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 13);
      this.label3.TabIndex = 113;
      this.label3.Text = "Third Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(7, 105);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 13);
      this.label2.TabIndex = 112;
      this.label2.Text = "Second Name";
      // 
      // tbFirstName
      // 
      this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbFirstName.Location = new System.Drawing.Point(96, 71);
      this.tbFirstName.Name = "tbFirstName";
      this.tbFirstName.Size = new System.Drawing.Size(112, 20);
      this.tbFirstName.TabIndex = 99;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(7, 79);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 111;
      this.label1.Text = "First Name";
      // 
      // tbAddress
      // 
      this.tbAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbAddress.Location = new System.Drawing.Point(96, 230);
      this.tbAddress.Name = "tbAddress";
      this.tbAddress.Size = new System.Drawing.Size(112, 20);
      this.tbAddress.TabIndex = 106;
      // 
      // tbPhone
      // 
      this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbPhone.Location = new System.Drawing.Point(96, 257);
      this.tbPhone.Name = "tbPhone";
      this.tbPhone.Size = new System.Drawing.Size(112, 20);
      this.tbPhone.TabIndex = 107;
      // 
      // tbLastName
      // 
      this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbLastName.Location = new System.Drawing.Point(96, 152);
      this.tbLastName.Name = "tbLastName";
      this.tbLastName.Size = new System.Drawing.Size(112, 20);
      this.tbLastName.TabIndex = 102;
      // 
      // tbThirdName
      // 
      this.tbThirdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbThirdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbThirdName.Location = new System.Drawing.Point(96, 125);
      this.tbThirdName.Name = "tbThirdName";
      this.tbThirdName.Size = new System.Drawing.Size(112, 20);
      this.tbThirdName.TabIndex = 101;
      // 
      // tbSecondName
      // 
      this.tbSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(233)))));
      this.tbSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
      this.tbSecondName.Location = new System.Drawing.Point(96, 98);
      this.tbSecondName.Name = "tbSecondName";
      this.tbSecondName.Size = new System.Drawing.Size(112, 20);
      this.tbSecondName.TabIndex = 100;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // AddUpdatePerson
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(213, 601);
      this.Controls.Add(this.btRemove);
      this.Controls.Add(this.btAddImage);
      this.Controls.Add(this.btSave);
      this.Controls.Add(this.lbText);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.tbEmail);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.tbNationalNo);
      this.Controls.Add(this.lbID);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.rbFemale);
      this.Controls.Add(this.rbMale);
      this.Controls.Add(this.pbImage);
      this.Controls.Add(this.cbCountries);
      this.Controls.Add(this.dtpDateOfBirth);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbFirstName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbAddress);
      this.Controls.Add(this.tbPhone);
      this.Controls.Add(this.tbLastName);
      this.Controls.Add(this.tbThirdName);
      this.Controls.Add(this.tbSecondName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "AddUpdatePerson";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add/Update User";
      this.Load += new System.EventHandler(this.AddUpdatePerson_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Button btRemove;
    private System.Windows.Forms.Button btAddImage;
    private System.Windows.Forms.Button btSave;
    private System.Windows.Forms.Label lbText;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox tbEmail;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox tbNationalNo;
    private System.Windows.Forms.Label lbID;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.RadioButton rbFemale;
    private System.Windows.Forms.RadioButton rbMale;
    private System.Windows.Forms.PictureBox pbImage;
    private System.Windows.Forms.ComboBox cbCountries;
    private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbFirstName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbAddress;
    private System.Windows.Forms.TextBox tbPhone;
    private System.Windows.Forms.TextBox tbLastName;
    private System.Windows.Forms.TextBox tbThirdName;
    private System.Windows.Forms.TextBox tbSecondName;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}