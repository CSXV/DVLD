using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD_Form {
  public partial class frmLicenseInfoForm : Form {
    private clsLicense _License;
    private clsDetain _Detain;

    public frmLicenseInfoForm(clsLicense License) {
      InitializeComponent();
      _License = License;
      _Detain = clsDetain.FindByLicenseID(_License.LicenseID);
    }

    public frmLicenseInfoForm(int License) {
      InitializeComponent();
      _License = clsLicense.Find(License);
      _Detain = clsDetain.FindByLicenseID(_License.LicenseID);
    }

    private void _LoadLicenseData() {
      lbClass.Text = _License.LicenseClassesInfo.ClassName;
      lbName.Text = _License.DriverInfo.PersonInfo.FullName();
      lbLicenseID.Text = _License.LicenseID.ToString();
      lbNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;

      lbIssueDate.Text = _License.IssueDate.ToString();
      lbIssueReason.Text = _License.ApplicationInfo.ApplicationTypeInfo.ApplicationTypeTitle;
      lbDateOfBirth.Text = _License.DriverInfo.PersonInfo.DateOfBirth.ToString();
      lbDriverID.Text = _License.DriverID.ToString();
      lbExpirationDate.Text = _License.ExpirationDate.ToString();

      if(_Detain != null) {
        if(_Detain.IsReleased == false) {
          lbIsDetained.Text = "Yes";
        } else {
          lbIsDetained.Text = "No";
        }
      } else {
        lbIsDetained.Text = "No";
      }

      if(_License.DriverInfo.PersonInfo.Gendor == 0) {
        lbGendor.Text = "Male";
      } else {
        lbGendor.Text = "female";
      }
      if(_License.Notes == null) {
        lbNotes.Text = "No notes";
      } else {
        lbNotes.Text = _License.Notes;
      }

      if(_License.IsActive == true) {
        lbIsActive.Text = "Yes";
      } else {
        lbIsActive.Text = "No";
      }
    }

    private void LicenseInfoForm_Load(object sender, System.EventArgs e) {
      _LoadLicenseData();
    }

    private void button2_Click(object sender, System.EventArgs e) {
      this.Close();
    }
  }
}
