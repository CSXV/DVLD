using DVLD_Form.Controls;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Users {
  public partial class frmChangeUserPassword : Form {
    public frmChangeUserPassword(int UserID) {
      InitializeComponent();

      var control = new cntrlChangeUserPassword();
      control.SetID(UserID);

      this.Controls.Add(control);
      control.Dock = DockStyle.Fill;
    }
  }
}
