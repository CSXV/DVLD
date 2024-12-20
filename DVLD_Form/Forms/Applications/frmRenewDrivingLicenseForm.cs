using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmRenewDrivingLicenseForm : Form {
    // Variables
    // ---------------------------------------------
    private clsLicense _NewLicense = new clsLicense();
    private clsLicense _OldLicense;
    private clsApplicationType _ApplicationType = clsApplicationType.Find(2);

    // Functions
    // ---------------------------------------------
    public frmRenewDrivingLicenseForm() {
      InitializeComponent();

      cntrlLicenseInfo2.DataBack += _SetLicense;
    }

    // ______________________
    private void _SetLicense(object sender, clsLicense license) {
      this._OldLicense = license;
      _UpdateControl();
    }

    private void _UpdateControl() {
      linkLabel1.Enabled = true;

      lbOldLicenseID.Text = _OldLicense.LicenseID.ToString();
      lbExperationDate.Text = Convert.ToString(DateTime.Now.AddYears(_OldLicense.LicenseClassesInfo.DefaultValidityLength));

      lbLicenseFees.Text = _OldLicense.LicenseClassesInfo.ClassFees.ToString();
      lbTotalFees.Text = Convert.ToString(_ApplicationType.ApplicationFees + _OldLicense.LicenseClassesInfo.ClassFees);
    }

    // ---------------------------------------------
    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseHistoryForm history = new frmLicenseHistoryForm(_OldLicense.DriverInfo.PersonInfo.NationalNo);
      history.ShowDialog();
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseInfoForm info = new frmLicenseInfoForm(_NewLicense);
      info.ShowDialog();
    }

    private void RenewDrivingLicenseForm_Load(object sender, System.EventArgs e) {
      lbCreatedByUserID.Text = GlobalState.LogedInUser.UserName;
      lbApplicationFees.Text = _ApplicationType.ApplicationFees.ToString();

      lbExperationDate.Text = Convert.ToString(DateTime.Now.AddYears(10));
      lbApplicationDate.Text = Convert.ToString(DateTime.Now);
      lbIssueDate.Text = Convert.ToString(DateTime.Now);
    }

    private void btSave_Click(object sender, EventArgs e) {
      clsApplications app = new clsApplications();

      app.ApplicationPersonID = _OldLicense.DriverInfo.PersonInfo.PersonID;
      app.ApplicationDate = DateTime.Now;
      app.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
      app.ApplicationStatus = 1;
      app.LastStautsDate = DateTime.Now;
      app.PaidFees = _ApplicationType.ApplicationFees;
      app.CreatedByUserID = GlobalState.LogedInUser.UserID;

      if(app.Save()) {
        _NewLicense.LicenseClass = _OldLicense.LicenseClass;
        _NewLicense.ApplicationID = app.ApplicationID;
        _NewLicense.DriverID = _OldLicense.DriverInfo.DriverID;
        _NewLicense.IssueDate = DateTime.Now;
        _NewLicense.ExpirationDate = DateTime.Now.AddYears(_OldLicense.LicenseClassesInfo.DefaultValidityLength);
        _NewLicense.Notes = tbNotes.Text;
        _NewLicense.IsActive = true;
        _NewLicense.PaidFees = _ApplicationType.ApplicationFees + _OldLicense.LicenseClassesInfo.ClassFees;
        _NewLicense.IssueReason = (byte)_ApplicationType.ApplicationTypeID;
        _NewLicense.CreatedByUserID = GlobalState.LogedInUser.UserID;

        _OldLicense.IsActive = false;

        if(_NewLicense.Save() && _OldLicense.Save()) {
          linkLabel2.Enabled = true;
          MessageBox.Show("License saved successfully");
        } else {
          MessageBox.Show("Error saving License");
        }
      } else {
        MessageBox.Show("Error saving License");
      }

      lbILA_ID.Text = app.ApplicationID.ToString();
      lbInternationalLicenseID.Text = _NewLicense.LicenseID.ToString();

      tbNotes.Enabled = false;
      btSave.Enabled = false;
    }

    private void btNext_Click(object sender, EventArgs e) {
      if(_OldLicense == null) {
        return;
      }

      if(!clsDetain.IsActiveDetainExistByLicenseID(_OldLicense.LicenseID)) {
        if(_OldLicense.ExpirationDate > DateTime.Now) {
          MessageBox.Show("License is not expired yet");
          btSave.Visible = false;
        } else if(_OldLicense.IsActive == false) {
          MessageBox.Show("Driver license is not active");
          btSave.Visible = false;
        } else {
          tabControl1.SelectedIndex = 1;
          btSave.Visible = true;
        }
      } else {
        MessageBox.Show("License is detained");
      }
    }
  }
}
