using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlAddUpdateUser : UserControl {
    // Delegate
    // ---------------------------------------------
    public delegate void DataBackEventHandler(object sender, int PersonID);

    public event DataBackEventHandler DataBackUserMain;

    // Variables
    // ---------------------------------------------
    private clsUser _User = new clsUser();

    // Functions
    // ---------------------------------------------
    public cntrlAddUpdateUser() {
      InitializeComponent();

      cntrlSearchBox1.DataBack += cntrlPersonInfo1.HandleData;
      cntrlSearchBox1.DataBack += _SetPersonID;

      this.DataBackUserMain += cntrlNewUser1.HandleData;
    }

    public void RaiseEvent() {
      DataBackUserMain?.Invoke(this, _User.PersonID);
    }

    // ______________________
    private void _SetPersonID(object sender, int PersonID) {
      this._User.PersonID = PersonID;
    }

    public void SetUser(clsUser User) {
      _User = User;
    }

    //// ---------------------------------------------
    public void UpdateControl() {
      cntrlNewUser1.SetID(_User.UserID);
      cntrlNewUser1.UpdateControl();

      cntrlPersonInfo1.SetID(_User.PersonID);
      cntrlPersonInfo1.UpdateControl();
    }

    private void cntrlAddUpdateUser_Load(object sender, EventArgs e) {
      if(clsUser.IsUserExist(_User.UserID)) {
        lbHeader.Text = "Update User";
        cntrlSearchBox1.Enabled = false;
      }

      UpdateControl();
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
      RaiseEvent();
    }

    private void btNext_Click(object sender, EventArgs e) {
      tabControl1.SelectedIndex = 1;
      RaiseEvent();
    }
  }
}
