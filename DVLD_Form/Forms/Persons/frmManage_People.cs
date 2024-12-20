using DVLD_BusinessLayer;
using DVLD_Form.Forms;
using System;
using System.Windows.Forms;

namespace DVLD_Form {
  public partial class frmManage_People : Form {
    private BindingSource _source = new BindingSource();

    public frmManage_People() { InitializeComponent(); }

    private void PeopleFrom_Load(object sender, EventArgs e) {
      _LoadPeopleData();
      cbFilter.SelectedIndex = 0;
    }

    private void _LoadPeopleData() {
      _source.DataSource = clsPerson.GetAllPeople();
      dataGridView1.DataSource = _source;
    }

    private void addToolStripMenuItem_Click(object sender, EventArgs e) {
      frmAddUpdatePerson addUser = new frmAddUpdatePerson(-1);
      addUser.ShowDialog();
      _LoadPeopleData();
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
      frmAddUpdatePerson adduser =
          new frmAddUpdatePerson((int)dataGridView1.CurrentRow.Cells[0].Value);
      adduser.ShowDialog();
      _LoadPeopleData();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
      int ID = (int)dataGridView1.CurrentRow.Cells[0].Value;

      if(MessageBox.Show("Do you really want to delete contact with ID = " + ID +
                              " ?",
                          "Delete Contact", MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Warning,
                          MessageBoxDefaultButton.Button2) == DialogResult.OK) {
        if(clsPerson.DeletePerson(ID)) {
          MessageBox.Show("Contact deleted successfully");
        } else {
          MessageBox.Show("Error: contact not deleted");
        }

        _LoadPeopleData();
      }
    }

    private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
      frmPersonInfo info =
          new frmPersonInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
      info.ShowDialog();
    }

    private void TbFilter_TextChanged(object sender, EventArgs e) {
      string selectedItem = cbFilter.SelectedItem.ToString();
      string FilterText = tbFilter.Text;

      switch(selectedItem) {
        case "None":
        break;
        case "NationalNo":
        case "FirstName":
        case "SecondName":
        case "ThirdName":
        case "LastName":
        case "Email":
        case "Phone":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"{selectedItem} LIKE '{FilterText}*'";
        }
        break;
        case "PersonID":
        if(!string.IsNullOrEmpty(FilterText)) {
          _source.Filter = $"PersonID = {FilterText}";
        }
        break;
        case "Nationality":
        // int CountryID = clsCountry.Find(FilterText).CountryID;

        if(!string.IsNullOrEmpty(FilterText)) {
          /*if (clsCountry.IsCountryExist(FilterText)) {*/
          /*if (clsCountry.Find(FilterText).CountryName == FilterText) {*/
          /*if (clsCountry.Find(FilterText).CountryName == FilterText) {*/
          /*clsCountry c = clsCountry.Find(FilterText);*/
          _source.Filter = $"NationalityCountryID = {FilterText}";
        }
        break;
        case "Gendor":
        if(!string.IsNullOrEmpty(FilterText)) {
          if(tbFilter.Text == "0" || tbFilter.Text == "Male" ||
              tbFilter.Text == "male") {
            _source.Filter = $"Gendor = 0";
          }
          if(tbFilter.Text == "1" || tbFilter.Text == "Female" ||
              tbFilter.Text == "female") {
            _source.Filter = $"Gendor = 1";
          }
        }
        break;
        default:
        _source.RemoveFilter();
        break;
      }
    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
      if(cbFilter.SelectedIndex == 0) {
        tbFilter.Visible = false;
        _source.RemoveFilter();
      } else {
        tbFilter.Visible = true;
      }
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
        case "Nationality":
        if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
          e.Handled = true;
        }
        break;
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      frmAddUpdatePerson addUser = new frmAddUpdatePerson(-1);
      addUser.ShowDialog();
      _LoadPeopleData();
    }

    private void button2_Click(object sender, EventArgs e) {
      _LoadPeopleData();
    }
  }
}
