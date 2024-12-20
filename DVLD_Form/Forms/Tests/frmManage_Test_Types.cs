using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Tests {
  public partial class frmManage_Test_Types : Form {
    private BindingSource _source = new BindingSource();

    public frmManage_Test_Types() {
      InitializeComponent();
    }

    private void _LoadTestTypesData() {
      _source.DataSource = clsTestType.GetAllTestTypes();
      dataGridView1.DataSource = _source;
    }

    private void editTestToolStripMenuItem_Click(object sender, EventArgs e) {
      frmUpdateTestType update =
          new frmUpdateTestType((int)dataGridView1.CurrentRow.Cells[0].Value);
      update.ShowDialog();
      _LoadTestTypesData();
    }

    private void TestTypesForm_Load(object sender, EventArgs e) {
      _LoadTestTypesData();
    }
  }
}
