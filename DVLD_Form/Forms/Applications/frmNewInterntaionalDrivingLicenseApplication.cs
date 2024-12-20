using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmNewInterntaionalDrivingLicenseApplication : Form {
    // Variables
    // ---------------------------------------------
    private clsInternationalLicense _IDL = new clsInternationalLicense();
    private clsLicense _License = new clsLicense();
    private clsApplicationType _ApplicationType = clsApplicationType.Find(6);

    // Functions
    // ---------------------------------------------
    public frmNewInterntaionalDrivingLicenseApplication() {
      InitializeComponent();

      cntrlLicenseInfo1.DataBack += _SetLicense;
    }

    // ______________________
    private void _SetLicense(object sender, clsLicense license) {
      this._License = license;
      linkLabel1.Enabled = true;
    }

    public void UpdateControl() {
      lbLocalLicenseID.Text = _License.LicenseID.ToString();
    }

    // ---------------------------------------------
    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseHistoryForm history = new frmLicenseHistoryForm(_License.DriverInfo.PersonInfo.NationalNo);
      history.ShowDialog();
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseInfoForm info = new frmLicenseInfoForm(_License);
      info.ShowDialog();
    }

    private void NewInterntaionalDrivingLicenseApplication_Load(object sender, EventArgs e) {
      UpdateControl();

      lbCreatedByUserID.Text = GlobalState.LogedInUser.UserName;
      lbApplicationFees.Text = _ApplicationType.ApplicationFees.ToString();

      lbExperationDate.Text = Convert.ToString(DateTime.Now.AddYears(1));
      lbApplicationDate.Text = Convert.ToString(DateTime.Now);
      lbIssueDate.Text = Convert.ToString(DateTime.Now);
    }

    private void btNext_Click(object sender, EventArgs e) {
      if(!clsDetain.IsActiveDetainExistByLicenseID(_License.LicenseID)) {
        if(_License.DriverInfo == null) {
          return;
        }
        if(clsInternationalLicense.IsLicenseExistByDriverID(_License.DriverInfo.DriverID)) {
          MessageBox.Show("Driver already had an international driving license");
          btSave.Visible = false;
        } else if(_License.IsActive == false) {
          MessageBox.Show("Driver license is not active");
          btSave.Visible = false;
        } else {
          tabControl1.SelectedIndex = 1;
          btSave.Visible = true;
        }
      } else {
        MessageBox.Show("License is Detained");
      }

      UpdateControl();
    }

    private void btSave_Click(object sender, EventArgs e) {
      clsApplications app = new clsApplications();

      app.ApplicationPersonID = _License.DriverInfo.PersonID;
      app.ApplicationDate = DateTime.Now;
      app.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
      app.ApplicationStatus = 1;
      app.LastStautsDate = DateTime.Now;
      app.PaidFees = _ApplicationType.ApplicationFees;
      app.CreatedByUserID = GlobalState.LogedInUser.UserID;

      if(app.Save()) {
        _IDL.ApplicationID = app.ApplicationID;
        _IDL.DriverID = _License.DriverInfo.DriverID;
        _IDL.IssuedUsingLocalLicenseID = _License.LicenseID;
        _IDL.IssueDate = DateTime.Now;
        _IDL.ExpirationDate = DateTime.Now.AddYears(1);
        _IDL.IsActive = true;
        _IDL.CreatedByUserID = GlobalState.LogedInUser.UserID;

        if(_IDL.Save()) {
          MessageBox.Show("License saved successfully");
          linkLabel2.Enabled = true;
        } else {
          MessageBox.Show("Error saving License");
        }
      } else {
        MessageBox.Show("Error saving License");
      }

      lbILA_ID.Text = app.ApplicationID.ToString();
      lbInternationalLicenseID.Text = _IDL.InternationalLicenseID.ToString();
      lbLocalLicenseID.Text = _License.LicenseID.ToString();
    }
  }
}
