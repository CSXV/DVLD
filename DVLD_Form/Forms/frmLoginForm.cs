using DVLD_BusinessLayer;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace DVLD_Form {
  public partial class frmLoginForm : Form {
    public frmLoginForm() { InitializeComponent(); }

    private void pbCancelUserName_Click(object sender, EventArgs e) {
      tbUser.Text = "";
      pbCancelUserName.Visible = false;
    }

    private void tbUser_TextChanged(object sender, EventArgs e) {
      pbCancelUserName.Visible = true;
    }

    private void tbUser_Enter(object sender, EventArgs e) {
    }

    private void pbCancelPassword_Click(object sender, EventArgs e) {
      tbPassword.Text = "";
      pbCancelPassword.Visible = false;
    }

    private void tbPassword_TextChanged(object sender, EventArgs e) {
      pbCancelPassword.Visible = true;
    }

    private void button1_Click(object sender, EventArgs e) {
      string Password = clsUtilites.ComputeHash(tbPassword.Text.Trim());
      clsUser user = clsUser.Find(tbUser.Text.Trim());

      if(user != null) {
        if(Password == user.Password) {
          if(user.IsActive) {
            if(cbRememberUser.Checked) {
              SaveToRegistry(tbUser.Text.Trim(), tbPassword.Text.Trim());
            } else {
              DeleteRegistry();
            }

            GlobalState.LogedInUser = user;
            this.Hide();
            frmMainForm main = new frmMainForm(this);
            main.ShowDialog();
          } else {
            MessageBox.Show("User is not active, contact your system admin", "User is not active", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        } else {
          MessageBox.Show("Wrong password", "Wrong credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
          tbPassword.Focus();
        }
      } else {
        MessageBox.Show("User not found", "wrong credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
        tbUser.Focus();
      }
    }

    private bool SaveToRegistry(string userName, string password) {
      string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

      try {
        Registry.SetValue(keyPath, "User Name", userName, RegistryValueKind.String);
        Registry.SetValue(keyPath, "Password", password, RegistryValueKind.String);

        return true;
      } catch(Exception ex) {
        Console.WriteLine("Error:" + ex.Message);

        return false;
      }
    }

    private void frmLoginForm_Load(object sender, EventArgs e) {
      string NameValue = "";
      string PasswordValue = "";

      if(CheckStoredCredi(ref NameValue, ref PasswordValue)) {
        tbUser.Text = NameValue;
        tbPassword.Text = PasswordValue;
      }
    }

    private void DeleteRegistry() {
      SaveToRegistry("", "");
    }

    private bool CheckStoredCredi(ref string NameValue, ref string PasswordValue) {
      string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
      string UserName = "User Name";
      string Password = "Password";

      try {
        NameValue = Registry.GetValue(keyPath, UserName, null) as string;
        PasswordValue = Registry.GetValue(keyPath, Password, null) as string;

        if(!string.IsNullOrEmpty(NameValue) && !string.IsNullOrEmpty(PasswordValue)) {
          return true;
        } else {
          return false;
        }
      } catch(Exception ex) {
        Console.WriteLine("Error:" + ex.Message);

        return false;
      }
    }
  }
}
