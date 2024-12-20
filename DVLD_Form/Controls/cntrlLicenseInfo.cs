using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlLicenseInfo : UserControl {
    public delegate void DataBackEventHandler(object sender, clsLicense License);
    public event DataBackEventHandler DataBack;

    private clsLicense _License;

    public cntrlLicenseInfo() {
      InitializeComponent();
    }

    public void RaiseEvent() {
      DataBack?.Invoke(this, _License);
    }

    private void tbSearch_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void _LoadLicenseData() {
      lbClass.Text = _License.LicenseClassesInfo.ClassName;
      lbName.Text = _License.DriverInfo.PersonInfo.FullName();
      lbLicenseID.Text = _License.LicenseID.ToString();
      lbIssueDate.Text = _License.IssueDate.ToString();
      lbDriverID.Text = _License.DriverID.ToString();
      lbDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();
      lbExpirationDate.Text = _License.ExpirationDate.ToString();
      lbIssueReason.Text = _License.ApplicationInfo.ApplicationTypeInfo.ApplicationTypeTitle;
      lbNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;

      lbIsActive.Text = _License.IsActive ? "Yes" : "No";
      lbGendor.Text = (_License.DriverInfo.PersonInfo.Gendor == 0) ? "Male" : "Female";
      lbNotes.Text = (_License.Notes == null) ? "No notes" : _License.Notes;
      lbIsDetained.Text = (clsDetain.IsActiveDetainExistByLicenseID(_License.LicenseID)) ? "Yes" : "No";
    }

    private void btSearch_Click(object sender, EventArgs e) {
      if(tbSearch.Text == null || tbSearch.Text == "") {
        return;
      }

      _License = clsLicense.Find(Convert.ToInt32(tbSearch.Text));

      if(_License == null) {
        MessageBox.Show("License not found");
        return;
      }

      _LoadLicenseData();
      RaiseEvent();
    }
  }
}
