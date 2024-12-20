using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlNewUser : UserControl {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    private clsUser _User;
    private int _UserID;
    private int _PersonID;

    public cntrlNewUser() {
      InitializeComponent();
    }

    private void cntrlUserInfo_Load(object sender, EventArgs e) {
      _LoadData();
    }

    public void HandleData(object sender, int PersonID) {
      _PersonID = PersonID;
    }

    public void SetID(int ID) {
      _UserID = ID;

      if(_UserID != -1) {
        _Mode = enMode.Update;
      } else {
        _Mode = enMode.AddNew;
      }
    }

    public void UpdateControl() {
      _LoadData();
    }

    private void _LoadData() {
      if(_Mode == enMode.AddNew) {
        _User = new clsUser();
        return;
      }

      _User = clsUser.Find(_UserID);

      if(_User == null) {
        MessageBox.Show("this form will now close");
        return;
      }

      lbUserID.Text = _User.UserID.ToString();
      tbUserName.Text = _User.UserName;

      cbIsActive.Checked = (_User.IsActive == true) ? true : false;
    }

    private void tbConfPassword_Validating(object sender, CancelEventArgs e) {
      if(tbPassword.Text != tbConfPassword.Text) {
        e.Cancel = true;
        tbConfPassword.Focus();
        errorProvider1.SetError(tbConfPassword, "Passwords not matched");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(tbConfPassword, "");
      }
    }

    private void btSave_Click(object sender, EventArgs e) {
      _User.UserName = tbUserName.Text;
      _User.Password = tbPassword.Text;
      _User.PersonID = _PersonID;

      if(cbIsActive.Checked) {
        _User.IsActive = true;
      } else {
        _User.IsActive = false;
      }

      if(_Mode == enMode.AddNew && (clsUser.IsUserExist(_User.UserName) || clsUser.IsUserExist(_User.UserID))) {
        MessageBox.Show("Error: already saved user.");
      } else if(_User.Save()) {
        MessageBox.Show("Person saved successfully");
      } else {
        MessageBox.Show("Error saving person");
      }

      _Mode = enMode.Update;
      lbUserID.Text = _User.UserID.ToString();
    }

    private void tbPassword_Validating(object sender, CancelEventArgs e) {
      if(_User != null) {
        if(_User.Password != tbPassword.Text) {
          e.Cancel = true;
          tbConfPassword.Focus();
          errorProvider1.SetError(tbConfPassword, "Passwords is not correct");
        } else {
          e.Cancel = false;
          errorProvider1.SetError(tbConfPassword, "");
        }
      }
    }
  }
}
