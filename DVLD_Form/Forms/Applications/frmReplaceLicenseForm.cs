using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmReplaceLicenseForm : Form {
    // Variables
    // ---------------------------------------------
    private clsApplicationType _applicationType3 = clsApplicationType.Find(3);
    private clsApplicationType _applicationType4 = clsApplicationType.Find(4);
    private clsLicense _NewLicense = new clsLicense();
    private clsLicense _OldLicense;

    // Functions
    // ---------------------------------------------
    public frmReplaceLicenseForm() {
      InitializeComponent();

      cntrlLicenseInfo2.DataBack += _SetLicense;
    }

    // ______________________
    private void _SetLicense(object sender, clsLicense license) {
      this._OldLicense = license;
      _UpdateControl();
    }

    private void _UpdateControl() {
      llHistory.Enabled = true;

      lbOldLicenseID.Text = _OldLicense.LicenseID.ToString();
      lbExperationDate.Text = Convert.ToString(DateTime.Now.AddYears(_OldLicense.LicenseClassesInfo.DefaultValidityLength));
    }

    // ---------------------------------------------
    private void rbLost_CheckedChanged(object sender, EventArgs e) {
      lbApplicationFees.Text = _applicationType3.ApplicationFees.ToString();
    }

    private void rbDamaged_CheckedChanged(object sender, EventArgs e) {
      lbApplicationFees.Text = _applicationType4.ApplicationFees.ToString();
    }

    private void ReplaceLicenseForm_Load(object sender, EventArgs e) {
      lbCreatedByUserID.Text = GlobalState.LogedInUser.UserName;

      lbExperationDate.Text = Convert.ToString(DateTime.Now.AddYears(10));
      lbApplicationDate.Text = Convert.ToString(DateTime.Now);
      lbIssueDate.Text = Convert.ToString(DateTime.Now);
    }

    private void llHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseHistoryForm history = new frmLicenseHistoryForm(_OldLicense.DriverInfo.PersonInfo.NationalNo);
      history.ShowDialog();
    }

    private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseInfoForm info = new frmLicenseInfoForm(_NewLicense);
      info.ShowDialog();
    }

    private void btNext_Click(object sender, EventArgs e) {
      if(_OldLicense == null) {
        return;
      }

      if(!clsDetain.IsActiveDetainExistByLicenseID(_OldLicense.LicenseID)) {
        if(_OldLicense.IsActive == false) {
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

    private void btSave_Click(object sender, EventArgs e) {
      clsApplications app = new clsApplications();

      app.ApplicationPersonID = _OldLicense.DriverInfo.PersonInfo.PersonID;
      app.ApplicationDate = DateTime.Now;

      if(rbLost.Checked == true) {
        app.ApplicationTypeID = 3;
      } else if(rbDamaged.Checked == true) {
        app.ApplicationTypeID = 4;
      }

      app.ApplicationStatus = 1;
      app.LastStautsDate = DateTime.Now;
      app.CreatedByUserID = GlobalState.LogedInUser.UserID;

      if(rbLost.Checked == true) {
        app.PaidFees = _applicationType3.ApplicationFees;
      } else if(rbDamaged.Checked == true) {
        app.PaidFees = _applicationType4.ApplicationFees;
      }

      if(app.Save()) {
        _NewLicense.ExpirationDate = DateTime.Now.AddYears(_OldLicense.LicenseClassesInfo.DefaultValidityLength);
        _NewLicense.CreatedByUserID = GlobalState.LogedInUser.UserID;
        _NewLicense.LicenseClass = _OldLicense.LicenseClass;
        _NewLicense.LicenseClassesInfo = _OldLicense.LicenseClassesInfo;
        _NewLicense.ApplicationID = app.ApplicationID;
        _NewLicense.DriverID = _OldLicense.DriverInfo.DriverID;
        _NewLicense.DriverInfo = _OldLicense.DriverInfo;
        _NewLicense.IssueDate = DateTime.Now;
        _NewLicense.Notes = tbNotes.Text;
        _NewLicense.IsActive = true;

        if(rbLost.Checked == true) {
          _NewLicense.PaidFees = Convert.ToDecimal(_applicationType3.ApplicationFees + _OldLicense.LicenseClassesInfo.ClassFees);
          _NewLicense.IssueReason = 3;
        } else if(rbDamaged.Checked == true) {
          _NewLicense.PaidFees = Convert.ToDecimal(_applicationType4.ApplicationFees + _OldLicense.LicenseClassesInfo.ClassFees);
          _NewLicense.IssueReason = 4;
        }

        _NewLicense.CreatedByUserID = GlobalState.LogedInUser.UserID;

        _OldLicense.IsActive = false;

        if(_NewLicense.Save() && _OldLicense.Save()) {
          llLicenseInfo.Enabled = true;
          MessageBox.Show("License replaced successfully with ID = " + _NewLicense.LicenseID);
        } else {
          clsApplications.DeleteApplication(app.ApplicationID);
          MessageBox.Show("Error replacing License");
        }
      }

      lbILA_ID.Text = app.ApplicationID.ToString();
      lbInternationalLicenseID.Text = _NewLicense.LicenseID.ToString();

      tbNotes.Enabled = false;
      btSave.Enabled = false;
      rbDamaged.Enabled = false;
      rbLost.Enabled = false;
    }
  }
}
