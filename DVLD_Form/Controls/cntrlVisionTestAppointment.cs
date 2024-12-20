using DVLD_BusinessLayer;
using DVLD_Form.Forms;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlVisionTestAppointment : UserControl {
    //----------------------------------------------------
    private clsLocalDrivingLicense _LDL;

    //----------------------------------------------------
    public cntrlVisionTestAppointment() {
      InitializeComponent();
    }

    public void HandleData(object sender, clsLocalDrivingLicense LDL) {
      _LDL = LDL;

      _LoadData();
    }

    private void cntrlVisionTestAppointment_Load(
                    object sender, EventArgs e) {
      //_LoadData();
    }

    private void _LoadData() {
      if(_LDL == null) {
        MessageBox.Show("this form will now close");
        return;
      }

      lbDLAID.Text =
        _LDL.LocalDrivingLicenseApplicationID.ToString();
      lbAppliedForLicense.Text = _LDL.LicenseClassInfo.ClassName;
      /*lbPassedTests.Text = _Application;*/

      lbAppID.Text = _LDL.ApplicationInfo.ApplicationID.ToString();

      switch(_LDL.ApplicationInfo.ApplicationStatus) {
        case 1:
        lbAppStatus.Text = "New";
        break;
        case 2:
        lbAppStatus.Text = "Cancelled";
        break;
        case 3:
        lbAppStatus.Text = "Completed";
        break;
      }

      lbAppFees.Text = _LDL.ApplicationInfo.ApplicationTypeInfo.ApplicationFees.ToString();
      lbAppType.Text = _LDL.ApplicationInfo.ApplicationTypeInfo.ApplicationTypeTitle;
      lbAppDate.Text = _LDL.ApplicationInfo.ApplicationDate.ToString();
      lbAppStatusDate.Text = lbAppDate.Text = _LDL.ApplicationInfo.LastStautsDate.ToString();

      lbAppApplicant.Text = _LDL.ApplicationInfo.ApplicantPersonInfo.FullName();
      lbAppCreatedBy.Text = _LDL.ApplicationInfo.UserInfo.UserName;
    }

    private void llViewPersonInfo_LinkClicked(object sender,
      LinkLabelLinkClickedEventArgs e) {
      frmPersonInfo info = new frmPersonInfo(_LDL.ApplicationInfo.ApplicantPersonInfo.PersonID);
      info.ShowDialog();
    }

    private void lbShowLicenseInfo_LinkClicked(object sender,
      LinkLabelLinkClickedEventArgs e) { }
  }
}
