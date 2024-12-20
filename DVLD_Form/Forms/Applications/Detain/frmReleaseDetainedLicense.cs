using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmReleaseDetainedLicense : Form {
    // Variables
    // ---------------------------------------------
    private clsDetain _Detain;
    private clsLicense _OldLicense;
    private clsApplicationType _ApplicationType = clsApplicationType.Find(5);

    // Functions
    // ---------------------------------------------
    public frmReleaseDetainedLicense() {
      InitializeComponent();

      cntrlLicenseInfo2.DataBack += _SetLicense;
    }

    // ______________________
    private void _SetLicense(object sender, clsLicense license) {
      this._OldLicense = license;
      _UpdateControl();
    }

    private void _UpdateControl() {
      _SetDetain();

      linkLabel1.Enabled = true;

      lbLicenseID.Text = _OldLicense.LicenseID.ToString();
      lbDetainID.Text = _Detain.DetainID.ToString();

      lbLicenseFees.Text = _Detain.FineFees.ToString();
      lbTotalFees.Text = Convert.ToString(_ApplicationType.ApplicationFees + _Detain.FineFees);
    }

    private void _SetDetain() {
      _Detain = clsDetain.FindByLicenseID(_OldLicense.LicenseID);
    }

    // ---------------------------------------------

    private void ReleaseDetainedLicense_Load(object sender, EventArgs e) {
      lbCreatedByUserID.Text = GlobalState.LogedInUser.UserName;
      lbApplicationFees.Text = _ApplicationType.ApplicationFees.ToString();

      lbDetainDate.Text = Convert.ToString(DateTime.Now);
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseHistoryForm history = new frmLicenseHistoryForm(_OldLicense.DriverInfo.PersonInfo.NationalNo);
      history.ShowDialog();
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseInfoForm info = new frmLicenseInfoForm(_OldLicense);
      info.ShowDialog();
    }

    private void btNext_Click(object sender, EventArgs e) {
      if(_OldLicense == null) {
        return;
      }

      if(!clsDetain.IsDetainExistByLicenseID(_OldLicense.LicenseID)) {
        MessageBox.Show("License is not Detained");
        btSave.Visible = false;

      } else if(_OldLicense.IsActive == false) {
        MessageBox.Show("Driver license is not active");
        btSave.Visible = false;
      } else {
        tabControl1.SelectedIndex = 1;
        btSave.Visible = true;
      }
    }

    private void btSave_Click(object sender, EventArgs e) {
      clsApplications app = new clsApplications();

      app.ApplicationPersonID = _OldLicense.DriverInfo.PersonInfo.PersonID;
      app.ApplicationDate = DateTime.Now;
      app.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
      app.ApplicationStatus = 1;
      app.LastStautsDate = DateTime.Now;
      app.PaidFees = _ApplicationType.ApplicationFees + _Detain.FineFees;
      app.CreatedByUserID = GlobalState.LogedInUser.UserID;

      if(app.Save()) {
        _Detain.ReleaseApplicationID = app.ApplicationID;
        _Detain.ReleasedByUserID = GlobalState.LogedInUser.UserID;
        _Detain.IsReleased = true;
        _Detain.ReleaseDate = DateTime.Now;

        if(_Detain.Save()) {
          linkLabel2.Enabled = true;
          MessageBox.Show("Detained License released successfully");
        } else {
          MessageBox.Show("Error releasing detained License");
        }
      } else {
        MessageBox.Show("Error releasing detained License");
      }

      lbApplicationID.Text = app.ApplicationID.ToString();

      btSave.Enabled = false;
    }
  }
}
