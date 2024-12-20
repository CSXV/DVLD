using DVLD_BusinessLayer;
using DVLD_Form.Forms.Users;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms {
  public partial class frmManage_Users : Form {
    private BindingSource _source = new BindingSource();

    public frmManage_Users() { InitializeComponent(); }

    private void UsersForm_Load(object sender, EventArgs e) {
      _LoadUsersData();
      cbFilter.SelectedIndex = 0;
    }

    private void _LoadUsersData() {
      _source.DataSource = clsUser.GetAllUsers();
      dgvUsers.DataSource = _source;

      foreach(DataGridViewColumn column in dgvUsers.Columns) {
        if(column.Name.Contains("Password")) {
          column.Visible = false;
        } else {
          column.Visible = true;
        }
      }
    }

    private void tbFilter_TextChanged(object sender, EventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();
      string FilterText = tbFilter.Text;

      switch(selectedItem) {
        case "None":
        _source.RemoveFilter();
        break;
        case "PersonID":
        case "UserID":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"{selectedItem} = {FilterText}";
        }
        break;
        case "IsActive":
        break;
        case "User Name":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"UserName LIKE '*{FilterText}*'";
        }
        break;
        default:
        _source.RemoveFilter();
        break;
      }
    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();
      switch(selectedItem) {
        case "None":
        tbFilter.Visible = false;
        cbIsActive.Visible = false;
        _source.RemoveFilter();
        break;
        case "IsActive":
        tbFilter.Visible = false;
        cbIsActive.Visible = true;
        cbIsActive.SelectedIndex = 0;
        break;
        case "PersonID":
        case "Full Name":
        case "User Name":
        tbFilter.Visible = true;
        cbIsActive.Visible = false;
        break;
      }
    }

    private void tsmiDelete_Click(object sender, EventArgs e) {
      int ID = (int)dgvUsers.CurrentRow.Cells[0].Value;

      if(MessageBox.Show(
              "Do you really want to delete User with ID = " + ID + " ?",
              "Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
              MessageBoxDefaultButton.Button2) == DialogResult.OK) {
        if(clsUser.DeleteUser(ID)) {
          MessageBox.Show("User deleted successfully");
        } else {
          MessageBox.Show("Error: User is not deleted");
        }

        _LoadUsersData();
      }
    }

    private void tsmiShowInfo_Click(object sender, EventArgs e) {
      ShowUserInfo showUserInfo =
          new ShowUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
      showUserInfo.ShowDialog();
    }

    private void tsmiAdd_Click(object sender, EventArgs e) {
      frmAddUpdateUser add = new frmAddUpdateUser(-1);
      add.ShowDialog();
      _LoadUsersData();
    }

    private void tsmiEdit_Click(object sender, EventArgs e) {
      frmAddUpdateUser Update =
          new frmAddUpdateUser((int)dgvUsers.CurrentRow.Cells[0].Value);
      Update.ShowDialog();
      _LoadUsersData();
    }

    private void tsmiChangePassword_Click(object sender, EventArgs e) {
      frmChangeUserPassword change =
          new frmChangeUserPassword((int)dgvUsers.CurrentRow.Cells[0].Value);
      change.ShowDialog();

      _LoadUsersData();
    }

    private void tbFilter_KeyPress(object sender, KeyPressEventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();

      switch(selectedItem) {
        case "None":
        break;
        case "PersonID":
        if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
          e.Handled = true;
        }
        break;
        case "UserID":
        if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
          e.Handled = true;
        }
        break;
      }
    }

    private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e) {
      string selectedItem = cbIsActive.SelectedItem.ToString();
      switch(selectedItem) {
        case "Yes":
        _source.Filter = "IsActive = 1";
        break;
        case "No":
        _source.Filter = "IsActive = 0";
        break;
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      frmAddUpdateUser addUser = new frmAddUpdateUser(-1);
      addUser.ShowDialog();
      _LoadUsersData();
    }

    private void button2_Click(object sender, EventArgs e) {
      _LoadUsersData();
    }
  }
}
