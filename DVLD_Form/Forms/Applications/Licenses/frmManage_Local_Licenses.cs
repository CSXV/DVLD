using DVLD_BusinessLayer;
using DVLD_Form.Forms.Tests;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class LocalLicensesForm : Form {
    private BindingSource _source = new BindingSource();
    private clsLocalDrivingLicense _Local;
    private clsLicense _License;

    public LocalLicensesForm() {
      InitializeComponent();
    }

    private void LocalLicensesForm_Load(object sender, EventArgs e) {
      _LoadLocalLicenseApp();
      tbFilter.Visible = false;
      cbFilter.SelectedIndex = 0;
    }

    private void _LoadLocalLicenseApp() {
      _source.DataSource = clsLocalDrivingLicense.GetAllLocalDrivingLicenseApplication();
      dataGridView1.DataSource = _source;
    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();
      switch(selectedItem) {
        case "None":
        tbFilter.Visible = false;
        _source.RemoveFilter();
        break;
        case "LocalDrivingLicenseApplicationID":
        case "NationalNo":
        case "FullName":
        case "Status":
        tbFilter.Visible = true;
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
        case "LocalDrivingLicenseApplicationID":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"{selectedItem} = {FilterText}";
        }
        break;
        case "NationalNo":
        case "FullName":
        case "Status":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"{selectedItem} LIKE '*{FilterText}*'";
        }
        break;
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
        case "LocalDrivingLicenseApplicationID":
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

    private void contextMenuStrip1_Opened(object sender, EventArgs e) {
      _License = null;

      switch(dataGridView1.CurrentRow.Cells[6].Value) {
        case "Cancelled":
        showApplicationDetailsToolStripMenuItem.Enabled = false;
        editApplicationToolStripMenuItem.Enabled = false;
        deleteApplicationToolStripMenuItem.Enabled = false;
        cancelApplicationToolStripMenuItem.Enabled = false;
        sechduleTestsToolStripMenuItem.Enabled = false;
        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        showLicenseToolStripMenuItem.Enabled = false;
        break;
        case "Completed":
        showApplicationDetailsToolStripMenuItem.Enabled = false;
        editApplicationToolStripMenuItem.Enabled = false;
        deleteApplicationToolStripMenuItem.Enabled = false;
        cancelApplicationToolStripMenuItem.Enabled = false;
        sechduleTestsToolStripMenuItem.Enabled = false;
        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        showLicenseToolStripMenuItem.Enabled = false;
        break;
        case "New":
        showApplicationDetailsToolStripMenuItem.Enabled = true;
        editApplicationToolStripMenuItem.Enabled = true;
        deleteApplicationToolStripMenuItem.Enabled = true;
        cancelApplicationToolStripMenuItem.Enabled = true;
        sechduleTestsToolStripMenuItem.Enabled = true;
        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        showLicenseToolStripMenuItem.Enabled = false;
        break;
      }

      switch((int)dataGridView1.CurrentRow.Cells[5].Value) {
        case 0:
        eyeToolStripMenuItem.Enabled = true;
        writtenTestToolStripMenuItem.Enabled = false;
        streetTestToolStripMenuItem.Enabled = false;
        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        break;
        case 1:
        eyeToolStripMenuItem.Enabled = false;
        writtenTestToolStripMenuItem.Enabled = true;
        streetTestToolStripMenuItem.Enabled = false;
        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        break;
        case 2:
        eyeToolStripMenuItem.Enabled = false;
        writtenTestToolStripMenuItem.Enabled = false;
        streetTestToolStripMenuItem.Enabled = true;
        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        break;
        case 3:
        eyeToolStripMenuItem.Enabled = false;
        writtenTestToolStripMenuItem.Enabled = false;
        streetTestToolStripMenuItem.Enabled = false;
        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
        break;
      }

      _Local = clsLocalDrivingLicense.Find((int)dataGridView1.CurrentRow.Cells[0].Value);

      if(_Local != null) {
        _License = clsLicense.FindByApplicationID(_Local.ApplicationInfo.ApplicationID);
        if(clsDriver.IsDriverExistByPersonID(_Local.ApplicationInfo.ApplicantPersonInfo.PersonID) == false) {
          showPersonLiToolStripMenuItem.Enabled = false;
        }
      }
      if(_License != null) {
        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
        showLicenseToolStripMenuItem.Enabled = true;
      }
    }

    private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
      MessageBox.Show("To be implemented");
    }

    private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
      MessageBox.Show("To be implemented");
    }

    private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
      int ID = (int)dataGridView1.CurrentRow.Cells[0].Value;

      if(MessageBox.Show(
              "Do you really want to delete Application with ID = " + ID + " ?",
              "Delete Application", MessageBoxButtons.OKCancel,
              MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button2) == DialogResult.OK) {
        if(clsLocalDrivingLicense.DeleteLocalLicenseApplication(ID)) {
          MessageBox.Show("Application deleted successfully");
        } else {
          MessageBox.Show("Error: Application is not deleted");
        }

        _LoadLocalLicenseApp();
      }
    }

    private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
      int ID = (int)dataGridView1.CurrentRow.Cells[0].Value;

      if(MessageBox.Show(
              "Do you really want to Cancel Application with ID = " + ID + " ?",
              "Cancel Application", MessageBoxButtons.OKCancel,
              MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button2) == DialogResult.OK) {
        if(clsLocalDrivingLicense.CancelLocalDrivingLicenseAppliction(ID)) {
          MessageBox.Show("Application canceled successfully");
        } else {
          MessageBox.Show("Error: Application is not canceled");
        }

        _LoadLocalLicenseApp();
      }
    }

    private void showPersonLiToolStripMenuItem_Click(object sender, EventArgs e) {
      frmLicenseHistoryForm history = new frmLicenseHistoryForm((string)dataGridView1.CurrentRow.Cells[2].Value);
      history.ShowDialog();
    }

    private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
      frmLicenseInfoForm licenseInfoForm = new frmLicenseInfoForm(_License);
      licenseInfoForm.ShowDialog();
    }

    private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e) {
      frmIssueDriverLicenseForTheFirstTIme issue = new frmIssueDriverLicenseForTheFirstTIme((int)dataGridView1.CurrentRow.Cells[0].Value);
      issue.ShowDialog();
    }

    private void eyeToolStripMenuItem_Click(object sender, EventArgs e) {
      frmTestAppointment visiontest =
          new frmTestAppointment((int)dataGridView1.CurrentRow.Cells[0].Value, 1);
      visiontest.ShowDialog();

      _LoadLocalLicenseApp();
    }

    private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e) {
      frmTestAppointment visiontest =
          new frmTestAppointment((int)dataGridView1.CurrentRow.Cells[0].Value, 2);
      visiontest.ShowDialog();

      _LoadLocalLicenseApp();
    }

    private void streetTestToolStripMenuItem_Click(object sender, EventArgs e) {
      frmTestAppointment visiontest =
          new frmTestAppointment((int)dataGridView1.CurrentRow.Cells[0].Value, 3);
      visiontest.ShowDialog();

      _LoadLocalLicenseApp();
    }

    private void button1_Click(object sender, EventArgs e) {
      frmNewLocalDrivingLicenseApplication local =
          new frmNewLocalDrivingLicenseApplication();
      local.ShowDialog();

      _LoadLocalLicenseApp();
    }

    private void button2_Click(object sender, EventArgs e) {
      _LoadLocalLicenseApp();
    }
  }
}
