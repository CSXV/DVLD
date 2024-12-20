using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmUpdateAppType : Form {
    private clsApplicationType _AppType;
    private int _AppID;

    public frmUpdateAppType(int AppTypeID) {
      InitializeComponent();

      _AppID = AppTypeID;
    }

    private void _LoadData() {
      _AppType = clsApplicationType.Find(_AppID);

      if(_AppType == null) {
        MessageBox.Show("this form will now close");
        return;
      }

      lbID.Text = _AppType.ApplicationTypeID.ToString();
      tbTitle.Text = _AppType.ApplicationTypeTitle;
      tbFees.Text = _AppType.ApplicationFees.ToString();
    }

    private void tbFees_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void UpdateAppType_Load(object sender, EventArgs e) { _LoadData(); }

    private void btSave_Click(object sender, EventArgs e) {
      _AppType.ApplicationTypeTitle = tbTitle.Text;
      _AppType.ApplicationFees = Convert.ToDecimal(tbFees.Text);

      if(_AppType.Save()) {

        MessageBox.Show("Application Type Updated successfully");
      } else {
        MessageBox.Show("Error Updating Application Type");
      }
    }
  }
}
