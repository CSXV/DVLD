using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlUserInfo : UserControl {
    private int _UserID;
    private clsUser _User;

    public cntrlUserInfo() { InitializeComponent(); }

    public void SetID(int userid) { _UserID = userid; }

    public void UpdateControl() { _LoadUserInfo(); }

    private void _LoadUserInfo() {
      _User = clsUser.Find(_UserID);

      lbUserID.Text = _User.UserID.ToString();
      lbUserName.Text = _User.UserName;

      if(_User.IsActive == true) {
        lbIsActive.Text = "YES";
      } else {
        lbIsActive.Text = "NO";
      }
    }
  }
}
