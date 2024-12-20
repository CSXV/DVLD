using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmManage_Application_Types : Form {
    private BindingSource _source = new BindingSource();

    public frmManage_Application_Types() { InitializeComponent(); }

    private void _LoadAppTypes() {
      _source.DataSource = clsApplicationType.GetAllApplicationTypes();
      dataGridView1.DataSource = _source;
    }

    private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
      frmUpdateAppType update =
          new frmUpdateAppType((int)dataGridView1.CurrentRow.Cells[0].Value);
      update.ShowDialog();
      _LoadAppTypes();
    }

    private void AppTypesForm_Load(object sender, EventArgs e) {
      _LoadAppTypes();
    }
  }
}
