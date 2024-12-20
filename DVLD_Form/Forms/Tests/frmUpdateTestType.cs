using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Tests {
  public partial class frmUpdateTestType : Form {
    private clsTestType _TestType;
    private int _TestID;

    public frmUpdateTestType(int TetsTypeID) {
      InitializeComponent();

      _TestID = TetsTypeID;
    }

    private void _LoadData() {
      _TestType = clsTestType.Find(_TestID);

      if(_TestType == null) {
        MessageBox.Show("this form will now close");
        return;
      }

      lbID.Text = _TestType.TestTypeID.ToString();
      tbTitle.Text = _TestType.TestTypeTitle;
      tbDescription.Text = _TestType.TestTypeDescription;
      tbFees.Text = _TestType.TestTypeFess.ToString();
    }

    private void tbFees_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void UpdateTestType_Load(object sender, EventArgs e) {
      _LoadData();
    }

    private void btSave_Click(object sender, EventArgs e) {
      _TestType.TestTypeTitle = tbTitle.Text;
      _TestType.TestTypeDescription = tbDescription.Text;
      _TestType.TestTypeFess = Convert.ToDecimal(tbFees.Text);

      if(_TestType.Save()) {
        MessageBox.Show("Test Type Updated successfully");
      } else {
        MessageBox.Show("Error Updating Test Type");
      }
    }
  }
}
