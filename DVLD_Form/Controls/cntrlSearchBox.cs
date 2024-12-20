using DVLD_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlSearchBox : UserControl {
    // Delegate
    public delegate void DataBackEventHandler(object sender, int PersonID);
    public event DataBackEventHandler DataBack;

    // Variables
    private BindingSource _source = new BindingSource();
    private DataTable _UsersTable = new DataTable();
    private int _PersonID = 0;

    // Functions
    public cntrlSearchBox() {
      InitializeComponent();
    }

    public void RaiseEvent() {
      DataBack?.Invoke(this, _PersonID);
    }

    private void _LoadPeopleData() {
      _UsersTable = clsPerson.GetAllPeople();
      _source.DataSource = _UsersTable;
    }

    private int _FindUser() {
      string selectedItem = cbFilter.SelectedItem.ToString();
      string FilterText = tbFilter.Text;
      DataRow[] filterrow;

      switch(selectedItem) {
        case "None":
        _source.RemoveFilter();
        break;
        case "PersonID":
        if(!string.IsNullOrEmpty(FilterText)) {
          filterrow = _UsersTable.Select($"PersonID = {FilterText}");

          foreach(DataRow row in filterrow) {
            _PersonID = (int)row["PersonID"];
            return _PersonID;
          }
        }
        break;
        case "NationalNo":
        if(!string.IsNullOrEmpty(FilterText)) {
          filterrow = _UsersTable.Select($"NationalNo LIKE '{FilterText}*'");

          foreach(DataRow row in filterrow) {
            _PersonID = (int)row["PersonID"];
            return _PersonID;
          }
        }
        break;
        default:
        _source.RemoveFilter();
        break;
      }

      return -1;
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
      }
    }

    private void cbFilter_SelectedIndexChanged(object sender, EventArgs e) {
      if(cbFilter.SelectedIndex == 0) {
        tbFilter.Visible = false;
      } else {
        tbFilter.Visible = true;
      }
    }

    private void cntrlSearchBox_Load(object sender, EventArgs e) {
      cbFilter.SelectedIndex = 0;
      _LoadPeopleData();
    }

    private void btSearch_Click(object sender, EventArgs e) {
      _PersonID = _FindUser();
      RaiseEvent();
    }
  }
}
