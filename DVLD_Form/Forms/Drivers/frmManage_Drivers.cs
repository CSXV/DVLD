using DVLD_BusinessLayer;
using DVLD_Form.Forms.Applications;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Drivers {
  public partial class frmManage_Drivers : Form {
    private BindingSource _source = new BindingSource();

    public frmManage_Drivers() { InitializeComponent(); }

    private void DriversForm_Load(object sender, EventArgs e) {
      _LoadDrivers();
      tbFilter.Visible = false;
    }

    private void _LoadDrivers() {
      _source.DataSource = clsDriver.GetAllDriversTable();
      dataGridView1.DataSource = _source;
    }

    private void tbFilter_TextChanged(object sender, EventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();
      string FilterText = tbFilter.Text;

      switch(selectedItem) {
        case "None":
        _source.RemoveFilter();
        break;
        case "DriverID":
        case "PersonID":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"{selectedItem} = {FilterText}";
        }
        break;
        case "NationalNo":
        case "FullName":
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
        case "PersonID":
        if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
          e.Handled = true;
        }
        break;
        case "DriverID":
        if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
          e.Handled = true;
        }
        break;
      }
    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();
      switch(selectedItem) {
        case "None":
        tbFilter.Visible = false;
        _source.RemoveFilter();
        break;
        case "DriverID":
        case "NationalNo":
        case "FullName":
        case "PersonID":
        tbFilter.Visible = true;
        break;
      }
    }

    private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
      frmLicenseHistoryForm history = new frmLicenseHistoryForm((int)dataGridView1.CurrentRow.Cells[0].Value);
      history.ShowDialog();
    }
  }
}
