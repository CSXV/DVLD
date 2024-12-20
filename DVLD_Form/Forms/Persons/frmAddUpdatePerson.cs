using DVLD_BusinessLayer;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Form.Forms {
  public partial class frmAddUpdatePerson : Form {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    private int _PersonID;
    private clsPerson _Person;

    public frmAddUpdatePerson(int PersonID) {
      InitializeComponent();
      _PersonID = PersonID;
      _Mode = (_PersonID != -1) ? enMode.Update : enMode.AddNew;
    }

    private void _FillCountriesComboBox() {
      DataTable dtCountries = clsCountry.GetAllCountries();

      foreach(DataRow row in dtCountries.Rows) {
        cbCountries.Items.Add(row["CountryName"]);
      }
    }

    public void _LoadData() {
      _FillCountriesComboBox();

      cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find("Jordan").CountryName);
      dtpDateOfBirth.MaxDate = (DateTime.Now.AddYears(-18));

      if(_Mode == enMode.AddNew) {
        btRemove.Visible = false;
        lbText.Text = "Add Person";
        _Person = new clsPerson();
        return;
      }

      _Person = clsPerson.Find(_PersonID);

      if(_Person == null) {
        //MessageBox.Show("this form will now close");
        return;
      }

      lbText.Text = "Edit Person";
      lbID.Text = _Person.PersonID.ToString();
      tbFirstName.Text = _Person.FirstName;
      tbSecondName.Text = _Person.SecondName;
      tbThirdName.Text = _Person.ThirdName;
      tbLastName.Text = _Person.LastName;
      tbNationalNo.Text = _Person.NationalNo;
      tbEmail.Text = _Person.Email;
      tbPhone.Text = _Person.Phone;
      tbAddress.Text = _Person.Address;
      dtpDateOfBirth.Value = _Person.DateOfBirth;

      if(_Person.ImagePath != "") {
        pbImage.Load(_Person.ImagePath);
        btRemove.Visible = true;
      } else {
        btRemove.Visible = false;
      }

      if(_Person.Gendor == 0) {
        rbMale.Checked = true;
        rbFemale.Checked = false;
      } else {
        rbMale.Checked = false;
        rbFemale.Checked = true;
      }

      cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(_Person.NationailtyCountryID).CountryName);
    }

    private void rbFemale_CheckedChanged(object sender, EventArgs e) {
      if((pbImage.ImageLocation == null) ||
          (pbImage.Image == Properties.Resources.Male)) {
        pbImage.Image = Properties.Resources.Female;
      }
    }

    private void rbMale_CheckedChanged(object sender, EventArgs e) {
      if((pbImage.ImageLocation == null) ||
          (pbImage.Image == Properties.Resources.Female)) {
        pbImage.Image = Properties.Resources.Male;
      }
    }

    private void btSave_Click(object sender, EventArgs e) {
      int CountryID = clsCountry.Find(cbCountries.Text).CountryID;
      string selectedFilePath = _Person.ImagePath;

      _Person.FirstName = tbFirstName.Text;
      _Person.SecondName = tbSecondName.Text;
      _Person.ThirdName = tbThirdName.Text;
      _Person.LastName = tbLastName.Text;
      _Person.NationalNo = tbNationalNo.Text;
      _Person.Email = tbEmail.Text;
      _Person.Phone = tbPhone.Text;
      _Person.Address = tbAddress.Text;
      _Person.DateOfBirth = dtpDateOfBirth.Value;
      _Person.NationailtyCountryID = CountryID;

      if(pbImage.ImageLocation != null) {
        _Person.ImagePath = pbImage.ImageLocation;
      } else {
        _Person.ImagePath = "";
      }

      if(rbFemale.Checked == true) {
        _Person.Gendor = 1;
      } else {
        _Person.Gendor = 0;
      }

      if(_Person.Save()) {
        if(_Person.ImagePath != selectedFilePath) {
          File.Delete(selectedFilePath);
        }

        MessageBox.Show("Person saved successfully");
      } else {
        MessageBox.Show("Error saving person");
      }

      _Mode = enMode.Update;
      lbText.Text = "Edit Person";
      lbID.Text = _Person.PersonID.ToString();
    }

    private void btAddImage_Click(object sender, EventArgs e) {
      openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*bmp;*.gif";
      openFileDialog1.FilterIndex = 1;
      openFileDialog1.RestoreDirectory = true;

      if(openFileDialog1.ShowDialog() == DialogResult.OK) {
        string selectedFilePath = openFileDialog1.FileName;
        string DestFolderPath = @"C:\DVLD_Images";
        string newFileName =
            Guid.NewGuid().ToString() + Path.GetExtension(selectedFilePath);
        string DestFilePath = Path.Combine(DestFolderPath, newFileName);

        File.Copy(selectedFilePath, DestFilePath);

        pbImage.Load(DestFilePath);
        btRemove.Visible = true;
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      if(rbFemale.Checked) {
        pbImage.Image = Properties.Resources.Female;
      }
      if(rbMale.Checked) {
        pbImage.Image = Properties.Resources.Male;
      }

      btRemove.Visible = false;
    }

    private void tbNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(clsPerson.IsPersonExist(tbNationalNo.Text) != false) {
        e.Cancel = true;
        tbNationalNo.Focus();
        errorProvider1.SetError(tbNationalNo, "National number is used for another user");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(tbNationalNo, "");
      }
    }

    private void AddUpdatePerson_Load(object sender, EventArgs e) {
      _LoadData();
    }
  }
}
