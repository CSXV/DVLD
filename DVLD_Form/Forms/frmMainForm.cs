using DVLD_Form.Forms;
using DVLD_Form.Forms.Applications;
using DVLD_Form.Forms.Drivers;
using DVLD_Form.Forms.Tests;
using DVLD_Form.Forms.Users;
using System;
using System.Windows.Forms;

namespace DVLD_Form {
  public partial class frmMainForm : Form {
    frmLoginForm _Loginform;

    public frmMainForm(frmLoginForm from) {
      InitializeComponent();
      _Loginform = from;
    }

    private void peopleToolStripMenuItem_Click(object sender, EventArgs e) {
      frmManage_People peopleFrom = new frmManage_People();
      peopleFrom.ShowDialog();
      peopleFrom.Close();
    }

    private void applicationsToolStripMenuItem_Click(object sender, EventArgs e) {
      applicationsToolStripMenuItem.ShowDropDown();
    }

    private void driversToolStripMenuItem_Click(object sender, EventArgs e) {
      frmManage_Drivers Driver = new frmManage_Drivers();
      Driver.ShowDialog();
    }

    private void usersToolStripMenuItem_Click(object sender, EventArgs e) {
      frmManage_Users usersForm = new frmManage_Users();
      usersForm.ShowDialog();
      usersForm.Close();
    }

    private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e) {
      accountSettingsToolStripMenuItem.ShowDropDown();
    }

    private void stmCurrentUserInfo_Click(object sender, EventArgs e) {
      ShowUserInfo info = new ShowUserInfo(GlobalState.LogedInUser.UserID);
      info.ShowDialog();
    }

    private void stiChangePassword_Click(object sender, EventArgs e) {
      frmChangeUserPassword change =
          new frmChangeUserPassword(GlobalState.LogedInUser.UserID);
      change.ShowDialog();
    }

    private void stiLogOut_Click(object sender, EventArgs e) {
      GlobalState.LogedInUser = null;
      _Loginform.ShowDialog();
      this.Close();
    }

    private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e) {
      frmManage_Application_Types app = new frmManage_Application_Types();
      app.ShowDialog();
    }

    private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e) {
      frmManage_Test_Types test = new frmManage_Test_Types();
      test.ShowDialog();
    }

    private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e) {
      LocalLicensesForm locallicense = new LocalLicensesForm();
      locallicense.ShowDialog();
    }

    private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      frmNewLocalDrivingLicenseApplication newlocal =
          new frmNewLocalDrivingLicenseApplication();
      newlocal.ShowDialog();
    }

    private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      frmNewInterntaionalDrivingLicenseApplication inter = new frmNewInterntaionalDrivingLicenseApplication();
      inter.ShowDialog();
    }

    private void internationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e) {
      frmManage_International_Licenses intern = new frmManage_International_Licenses();
      intern.ShowDialog();
    }

    private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      frmRenewDrivingLicenseForm re = new frmRenewDrivingLicenseForm();
      re.ShowDialog();
    }

    private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      frmReplaceLicenseForm replace = new frmReplaceLicenseForm();
      replace.ShowDialog();
    }

    private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      DetainALicense detain = new DetainALicense();
      detain.ShowDialog();
    }

    private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e) {
      DetainALicense managedetain = new DetainALicense();
      managedetain.ShowDialog();
    }

    private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      frmReleaseDetainedLicense release = new frmReleaseDetainedLicense();
      release.ShowDialog();
    }

    private void releseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      frmReleaseDetainedLicense release = new frmReleaseDetainedLicense();
      release.ShowDialog();
    }

    private void btAddLicense_Click(object sender, EventArgs e) {
      frmNewLocalDrivingLicenseApplication local = new frmNewLocalDrivingLicenseApplication();
      local.ShowDialog();
    }

    private void btDetainLicense_Click(object sender, EventArgs e) {
      Manage_Detain_Licenses detain = new Manage_Detain_Licenses();
      detain.ShowDialog();
    }

    private void btAddIntLicense_Click(object sender, EventArgs e) {
      frmNewInterntaionalDrivingLicenseApplication inter = new frmNewInterntaionalDrivingLicenseApplication();
      inter.ShowDialog();
    }

    private void btRenewLicense_Click(object sender, EventArgs e) {
      frmRenewDrivingLicenseForm renew = new frmRenewDrivingLicenseForm();
      renew.ShowDialog();
    }
  }
}
