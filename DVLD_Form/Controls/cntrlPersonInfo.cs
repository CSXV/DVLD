using DVLD_BusinessLayer;
using DVLD_Form.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlPersonInfo : UserControl {
    private int _PersonID;
    private clsPerson _Person;

    public cntrlPersonInfo() {
      InitializeComponent();
    }

    public void HandleData(object sender, int PersonID) {
      _PersonID = PersonID;
      _LoadPersonData();
    }

    public void SetID(int ID) {
      _PersonID = ID;
    }

    public void UpdateControl() {
      _LoadPersonData();
    }

    private void _LoadPersonData() {
      _Person = clsPerson.Find(_PersonID);

      if(_Person == null) {
        //MessageBox.Show("No person found");
        return;
      }

      lbID.Text = _Person.PersonID.ToString();
      lbFirstName.Text = _Person.FirstName;
      lbSecondName.Text = _Person.SecondName;
      lbThirdName.Text = _Person.ThirdName;
      lbLastName.Text = _Person.LastName;
      lbNationalNo.Text = _Person.NationalNo;
      lbEmail.Text = _Person.Email;
      lbPhone.Text = _Person.Phone;
      lbAddress.Text = _Person.Address;
      lbDateOfBirth.Text = _Person.DateOfBirth.ToString();

      string imagepath = _Person.ImagePath;
      if(_Person.ImagePath != "") {
        if(File.Exists(imagepath)) {
          pbImage.Load(imagepath);
        }
      }

      if(_Person.Gendor == 0) {
        lbGendor.Text = "Male";
      } else {
        lbGendor.Text = "Female";
      }

      lbCountry.Text = clsCountry.Find(_Person.NationailtyCountryID).CountryName;
    }

    private void UserControl1_Load(object sender, EventArgs e) {
      _LoadPersonData();
    }

    private void button2_Click(object sender, EventArgs e) {
      frmAddUpdatePerson add = new frmAddUpdatePerson(_PersonID);
      add.ShowDialog();

      _LoadPersonData();
    }
  }
}
