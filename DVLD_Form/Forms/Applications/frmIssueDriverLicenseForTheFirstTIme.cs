using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmIssueDriverLicenseForTheFirstTIme : Form {
    //----------------------------------------------------
    public delegate void DataBackEventHandler(
      object sender, clsLocalDrivingLicense _LDL);
    public event DataBackEventHandler DataBack;

    private clsLocalDrivingLicense _LDL;
    private int _LDLID;
    private int _DriverID;

    //----------------------------------------------------
    private void _RaiseEvent() {
      DataBack?.Invoke(this, _LDL);
    }

    //----------------------------------------------------
    public frmIssueDriverLicenseForTheFirstTIme(int LDLID) {
      InitializeComponent();

      _LDLID = LDLID;

      DataBack += cntrlVisionTestAppointment1.HandleData;
    }

    private void IssueDriverLicenseForTheFirstTIme_Load(object sender, EventArgs e) {
      _LDL = clsLocalDrivingLicense.Find(_LDLID);

      _RaiseEvent();
    }

    private bool _CreateNewDriver() {
      clsDriver Driver = new clsDriver();

      if(clsDriver.IsDriverExistByPersonID(_LDL.ApplicationInfo.ApplicationPersonID) == false) {
        Driver.PersonID = _LDL.ApplicationInfo.ApplicationPersonID;
        Driver.CreatedByUserID = GlobalState.LogedInUser.UserID;
        Driver.CreatedDate = DateTime.Now;

        if(Driver.Save()) {
          _DriverID = Driver.DriverID;
        } else {
          MessageBox.Show("Error creating driver");
          return false;
        }
      }

      return true;
    }

    private bool _CreateNewLicense() {
      clsLicense license = new clsLicense();

      license.ApplicationID = _LDL.ApplicationInfo.ApplicationID;
      license.DriverID = _DriverID;
      license.LicenseClass = _LDL.LicenseClassInfo.LicenseClassID;
      license.IssueDate = DateTime.Now;
      license.ExpirationDate = DateTime.Now.AddYears(_LDL.LicenseClassInfo.DefaultValidityLength);
      license.PaidFees = _LDL.LicenseClassInfo.ClassFees;
      license.IsActive = true;
      license.IssueReason = 1;
      license.CreatedByUserID = GlobalState.LogedInUser.UserID;

      if(tbNotes.Text == null) {
        license.Notes = null;
      } else {
        license.Notes = tbNotes.Text;
      }

      if(license.Save()) {
        _LDL.ApplicationInfo.ApplicationStatus = 3;
        _LDL.ApplicationInfo.Save();

        MessageBox.Show("License issued successfully");
        return true;
      } else {
        MessageBox.Show("Error Issuing lincense");
        return false;
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      if(_CreateNewDriver()) {
        _CreateNewLicense();
      }
    }
  }
}
