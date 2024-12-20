using DVLD_BusinessLayer;
using DVLD_Form.Controls;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Users {
  public partial class frmAddUpdateUser : Form {
    private clsUser _User;
    private int _UserId;

    public frmAddUpdateUser(int UserID) {
      InitializeComponent();

      _UserId = UserID;

      _FindUser();
      _IntializeControls();
    }

    private void _FindUser() {
      _User = clsUser.Find(_UserId);

      if(_User == null) {
        _User = new clsUser();
        _User.UserID = -1;
      }

    }

    private void _IntializeControls() {
      var control = new cntrlAddUpdateUser();
      control.SetUser(_User);

      this.Controls.Add(control);
      control.Dock = DockStyle.Fill;
    }
  }
}
