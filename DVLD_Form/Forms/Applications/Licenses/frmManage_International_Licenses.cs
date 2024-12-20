using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmManage_International_Licenses : Form {
    private BindingSource _source = new BindingSource();
    private clsLicense _License;

    public frmManage_International_Licenses() {
      InitializeComponent();
    }

    private void InternationalLicensesForm_Load(object sender, EventArgs e) {
      _LoadLocalLicenseApp();
      tbFilter.Visible = false;
      cbFilter.SelectedIndex = 0;
      cbIsActive.Visible = false;
    }

    private void _LoadLocalLicenseApp() {
      _source.DataSource =
          clsInternationalLicense.GetAllInternationalLicenses();
      dataGridView1.DataSource = _source;
    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();
      switch(selectedItem) {
        case "None":
        tbFilter.Visible = false;
        cbIsActive.Visible = false;
        _source.RemoveFilter();
        break;
        case "InternationalLicenseID":
        case "ApplicationID":
        case "DriverID":
        case "IssuedUsingLocalLicenseID":
        case "CreatedByUserID":
        tbFilter.Visible = true;
        cbIsActive.Visible = false;
        break;
        case "IsActive":
        tbFilter.Visible = false;
        cbIsActive.Visible = true;
        cbIsActive.SelectedIndex = 0;
        break;
      }
    }

    private void tbFilter_TextChanged(object sender, EventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();
      string FilterText = tbFilter.Text;

      switch(selectedItem) {
        case "None":
        _source.RemoveFilter();
        break;
        case "InternationalLicenseID":
        case "ApplicationID":
        case "DriverID":
        case "IssuedUsingLocalLicenseID":
        case "CreatedByUserID":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"{selectedItem} = {FilterText}";
        }
        break;
        /*case "FullName":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"{selectedItem} LIKE '*{FilterText}*'";
        }
        break;*/
        default:
        _source.RemoveFilter();
        break;
      }
    }

    private void tbFilter_KeyPress(object sender, KeyPressEventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();

      switch(selectedItem) {
        case "None":
        break;
        case "InternationalLicenseID":
        case "ApplicationID":
        case "DriverID":
        case "IssuedUsingLocalLicenseID":
        case "CreatedByUserID":
        if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
          e.Handled = true;
        }
        break;
        /*case "ApplicationStatus":*/
        /*  if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))*/
        /*  {*/
        /*    e.Handled = true;*/
        /*  }*/
        /*  break;*/
      }
    }

    private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e) {
      string selectedItem = cbIsActive.SelectedItem.ToString();
      switch(selectedItem) {
        case "Yes":
        _source.Filter = "IsActive = 1";
        break;
        case "No":
        _source.Filter = "IsActive = 0";
        break;
      }
    }

    private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
      _License = new clsLicense();
      _License.DriverInfo = clsDriver.Find((int)dataGridView1.CurrentRow.Cells[2].Value);

      if(_License.DriverInfo != null) {
        frmPersonInfo info = new frmPersonInfo(_License.DriverInfo.PersonID);
        info.ShowDialog();
      }
    }

    private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
      _License = clsLicense.Find((int)dataGridView1.CurrentRow.Cells[3].Value);

      if(_License != null) {
        frmLicenseInfoForm linfo = new frmLicenseInfoForm(_License);
        linfo.ShowDialog();
      }
    }

    private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
      _License.DriverInfo = clsDriver.Find((int)dataGridView1.CurrentRow.Cells[2].Value);

      frmLicenseHistoryForm history = new frmLicenseHistoryForm(_License.DriverInfo.PersonInfo.NationalNo);
      history.ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e) {
      frmNewInterntaionalDrivingLicenseApplication local =
          new frmNewInterntaionalDrivingLicenseApplication();
      local.ShowDialog();

      _LoadLocalLicenseApp();
    }

    private void button2_Click(object sender, EventArgs e) {
      _LoadLocalLicenseApp();
    }
  }
}
