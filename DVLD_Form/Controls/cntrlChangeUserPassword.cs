using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlChangeUserPassword : UserControl {
    private clsUser _User;

    public cntrlChangeUserPassword() {
      InitializeComponent();
    }

    public void SetID(int UserID) {
      _User = clsUser.Find(UserID);

      if(_User == null) {
        return;
      }
    }

    public void UpdateControl() {
      cntrlPersonInfo1.SetID(_User.PersonID);
      cntrlPersonInfo1.UpdateControl();

      cntrlUserInfo1.SetID(_User.UserID);
      cntrlUserInfo1.UpdateControl();
    }

    private void tbCurrentPassword_Validating(object sender, CancelEventArgs e) {
      if(String.IsNullOrEmpty(tbCurrentPassword.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(tbCurrentPassword, "Password cannot be empty");
        return;
      } else {
        e.Cancel = false;
        errorProvider1.SetError(tbCurrentPassword, "");
      }

      if(clsUtilites.ComputeHash(tbCurrentPassword.Text.Trim()) != _User.Password) {
        //if(tbCurrentPassword.Text != _User.Password) {
        e.Cancel = true;
        tbCurrentPassword.Focus();
        errorProvider1.SetError(tbCurrentPassword, "Password is wrong");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(tbCurrentPassword, "");
      }
    }

    private void tbConfirmPassword_Validating(object sender, CancelEventArgs e) {
      if(tbConfirmPassword.Text != tbNewPassword.Text) {
        e.Cancel = true;
        tbConfirmPassword.Focus();
        errorProvider1.SetError(tbConfirmPassword, "Password not matched");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(tbConfirmPassword, "");
      }
    }

    private void cntrlChangeUserPassword_Load(object sender, EventArgs e) {
      UpdateControl();
    }

    private void btSave_Click(object sender, EventArgs e) {
      _User.Password = tbConfirmPassword.Text;

      if(_User.Save()) {
        MessageBox.Show("Password updated successfully");
      } else {
        MessageBox.Show("Error updating password");
      }
    }
  }
}
