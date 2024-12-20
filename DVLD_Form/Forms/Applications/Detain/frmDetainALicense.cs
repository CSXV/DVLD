using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class Manage_Detain_Licenses : Form {
    // Variables
    // ---------------------------------------------
    private clsApplicationType _applicationType = clsApplicationType.Find(2);
    private clsDetain _Detain = new clsDetain();
    private clsLicense _OldLicense;

    // Functions
    // ---------------------------------------------
    public Manage_Detain_Licenses() {
      InitializeComponent();

      cntrlLicenseInfo2.DataBack += _SetLicense;
    }

    private void _SetLicense(object sender, clsLicense license) {
      this._OldLicense = license;
      _UpdateControl();
    }

    private void _UpdateControl() {
      linkLabel1.Enabled = true;
      lbInternationalLicenseID.Text = _OldLicense.LicenseID.ToString();
    }

    // ---------------------------------------------
    private void DetainLicenseForm_Load(object sender, EventArgs e) {
      lbCreatedByUserID.Text = GlobalState.LogedInUser.UserName;
      lbApplicationDate.Text = Convert.ToString(DateTime.Now);
    }

    private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseHistoryForm history = new frmLicenseHistoryForm(_OldLicense.DriverInfo.PersonInfo.NationalNo);
      history.ShowDialog();
    }

    private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e) {
      frmLicenseInfoForm info = new frmLicenseInfoForm(_OldLicense);
      info.ShowDialog();
    }

    private void tbFees_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void btSave_Click(object sender, EventArgs e) {
      _Detain.LicenseID = _OldLicense.LicenseID;
      _Detain.DetainDate = DateTime.Now;
      _Detain.CreatedByUserID = GlobalState.LogedInUser.UserID;

      if(String.IsNullOrEmpty(tbFees.Text)) {
        MessageBox.Show("fees cannot be empty");
        return;
      } else {
        _Detain.FineFees = Convert.ToDecimal(tbFees.Text);
      }

      if(_Detain.Save()) {
        linkLabel2.Enabled = true;
        MessageBox.Show("Detain saved successfully");
      } else {
        MessageBox.Show("Error saving Detain");
      }

      lbILA_ID.Text = _Detain.DetainID.ToString();

      btSave.Enabled = false;
      tbFees.Enabled = false;
    }

    private void btNext_Click(object sender, EventArgs e) {
      if(_OldLicense == null) {
        return;
      }

      if(clsDetain.IsDetainExistByLicenseID(_OldLicense.LicenseID)) {
        MessageBox.Show("License is already detained");
        btSave.Visible = false;
      } else if(_OldLicense.IsActive == false) {
        MessageBox.Show("Driver license is not active");
        btSave.Visible = false;
      } else {
        tabControl1.SelectedIndex = 1;
        btSave.Visible = true;
      }
    }
  }
}
