using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlDriverLicenses : UserControl {
    public cntrlDriverLicenses() {
      InitializeComponent();
    }

    public void SetLocalDataGridViewDataSource(BindingSource source) {
      dgvLocal.DataSource = source;
    }

    public void SetInternationalDataGridViewDataSource(BindingSource source) {
      dgvInternational.DataSource = source;
    }

    public bool DisableInternationalDataGridView() {
      return dgvInternational.Enabled = false;
    }

    public bool DisableLocalDataGridView() {
      return dgvLocal.Enabled = false;
    }

    private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, System.EventArgs e) {
      frmLicenseInfoForm info = new frmLicenseInfoForm((int)dgvLocal.CurrentRow.Cells[0].Value);
      info.ShowDialog();
    }
  }
}
