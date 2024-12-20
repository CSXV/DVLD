using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Tests {
  public partial class frmTakeTestForm : Form {
    private clsTests _Test = new clsTests();
    private clsTestAppointment _TestApp;
    private int _TestAppID;
    private decimal _Fees;

    public frmTakeTestForm(int TestAppID) {
      InitializeComponent();

      _TestAppID = TestAppID;
    }

    private void _LoadTestType() {
      _TestApp = clsTestAppointment.Find(_TestAppID);
      _Fees = _TestApp.PaidFees;
    }

    private void rbPass_Click(object sender, EventArgs e) {
      rbFail.Checked = false;
    }

    private void rbFail_Click(object sender, EventArgs e) {
      rbPass.Checked = false;
    }

    private void TakeTestForm_Load(object sender, EventArgs e) {
      _LoadTestType();
    }

    private void btSave_Click(object sender, EventArgs e) {
      _Test.CreatedByUserID = GlobalState.LogedInUser.UserID;
      _Test.TestAppointmentID = _TestAppID;
      _Test.Notes = tbNotes.Text;

      if(rbFail.Checked == true) {
        _Test.TestResults = false;
      } else {
        _Test.TestResults = true;
      }

      _TestApp.IsLocked = true;
      _TestApp.PaidFees = _Fees;

      if(_Test.Save() && _TestApp.Save()) {
        MessageBox.Show("Saved successfully");
      } else {
        MessageBox.Show("Error saving test");
      }
    }
  }
}
