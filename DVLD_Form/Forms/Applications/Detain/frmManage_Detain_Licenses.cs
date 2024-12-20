using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class DetainALicense : Form {
    private BindingSource _source = new BindingSource();
    private clsLicense _License;

    public DetainALicense() {
      InitializeComponent();
    }

    private void ManageDetainedLicenses_Load(object sender, EventArgs e) {
      _LoadDetained();
      tbFilter.Visible = false;
      cbFilter.SelectedIndex = 0;
      cbIsActive.Visible = false;
    }

    private void _LoadDetained() {
      _source.DataSource =
          clsDetain.GetAllDetains();
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
        case "DetainID":
        case "LicenseID":
        case "FineFees":
        case "CreatedByUserID":
        case "ReleasedByUserID":
        case "ReleaseApplicationID":
        tbFilter.Visible = true;
        cbIsActive.Visible = false;
        break;
        case "IsReleased":
        tbFilter.Visible = false;
        cbIsActive.Visible = true;
        cbIsActive.SelectedIndex = 0;
        break;
      }
    }

    private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e) {
      string selectedItem = cbIsActive.SelectedItem.ToString();
      switch(selectedItem) {
        case "Yes":
        _source.Filter = "IsReleased = 1";
        break;
        case "No":
        _source.Filter = "IsReleased = 0";
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
        case "DetainID":
        case "LicenseID":
        case "FineFees":
        case "CreatedByUserID":
        case "ReleasedByUserID":
        case "ReleaseApplicationID":
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
        case "DetainID":
        case "LicenseID":
        case "FineFees":
        case "CreatedByUserID":
        case "ReleasedByUserID":
        case "ReleaseApplicationID":
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

    private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
      _License = clsLicense.Find((int)dataGridView1.CurrentRow.Cells[1].Value);

      frmPersonInfo person = new frmPersonInfo(_License.DriverInfo.PersonID);
      person.ShowDialog();
    }

    private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
      _License = clsLicense.Find((int)dataGridView1.CurrentRow.Cells[1].Value);

      frmLicenseInfoForm info = new frmLicenseInfoForm(_License);
      info.ShowDialog();
    }

    private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
      _License = clsLicense.Find((int)dataGridView1.CurrentRow.Cells[1].Value);

      frmLicenseHistoryForm history = new frmLicenseHistoryForm(_License.DriverID);
      history.ShowDialog();
    }

    private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      if((bool)dataGridView1.CurrentRow.Cells[5].Value == false) {
        frmReleaseDetainedLicense release = new frmReleaseDetainedLicense();
        release.ShowDialog();
      } else {
        MessageBox.Show("License already released");
      }
    }

    private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
      _License = clsLicense.Find((int)dataGridView1.CurrentRow.Cells[1].Value);

      if(clsDetain.IsActiveDetainExistByLicenseID(_License.LicenseID)) {
        releaseDetainedLicenseToolStripMenuItem.Enabled = true;
      } else {
        releaseDetainedLicenseToolStripMenuItem.Enabled = false;
        return;
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      Manage_Detain_Licenses detain = new Manage_Detain_Licenses();
      detain.ShowDialog();

      _LoadDetained();
    }

    private void button2_Click(object sender, EventArgs e) {
      _LoadDetained();
    }
  }
}
