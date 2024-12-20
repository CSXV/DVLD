using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Users {
  public partial class ShowUserInfo : Form {
    private clsUser _User = new clsUser();

    public ShowUserInfo(int UserID) {
      InitializeComponent();

      _User = clsUser.Find(UserID);

      cntrlPersonInfo1.SetID(_User.PersonID);
      cntrlPersonInfo1.UpdateControl();

      cntrlUserInfo1.SetID(_User.UserID);
      cntrlUserInfo1.UpdateControl();
    }
  }
}
