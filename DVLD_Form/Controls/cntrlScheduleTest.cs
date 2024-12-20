using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Controls {
  public partial class cntrlScheduleTest : UserControl {
    //----------------------------------------------------
    private enum enMode { New = 0, Retake = 1 }
    enMode _Mode;

    //private clsTestAppointment _Appointment;
    private clsLocalDrivingLicense _LDL;
    private clsTestType _TestType;

    //----------------------------------------------------
    private void _LoadData() {
      if(_LDL.DoesAttendTestType(_TestType.TestTypeID)) {
        _Mode = enMode.Retake;
      } else {
        _Mode = enMode.New;
      }

      if(_Mode == enMode.Retake) {
        lbRetakeFees.Text = _TestType.TestTypeFess.ToString();
        lbRetakeTestApplicationID.Text = "0";
        groupBox2.Enabled = true;
      } else {
        groupBox2.Enabled = false;
        lbRetakeTestApplicationID.Text = "N/A";
        lbRetakeFees.Text = "0";
      }

      lbDLAID.Text =
        _LDL.LocalDrivingLicenseApplicationID.ToString();
      lbFees.Text = _TestType.TestTypeFess.ToString();
      lbDLClass.Text = _LDL.LicenseClassInfo.ClassName;
      lbName.Text = _LDL.ApplicationInfo.ApplicantPersonInfo.FullName();
      lbTrial.Text = _LDL.TotalTrialsPerTest(_TestType.TestTypeID).ToString();
      dtpDate.MinDate = DateTime.Now;

      lbRetakeFees.Text = 5.ToString();
      lbTotalFees.Text =
        (Convert.ToDecimal(lbRetakeFees.Text) +
        Convert.ToDecimal(_TestType.TestTypeFess)).ToString();

      _HandleLock();
    }

    private bool _HandleLock() {
      //_Appointment = clsTestAppointment.Find(_LDL.ApplicationInfo.Ap);

      /*if(_Appointment.IsLocked) {
        groupBox1.Enabled = false;
        groupBox2.Enabled = false;
        return false;
      }*/

      return true;
    }

    //----------------------------------------------------
    public cntrlScheduleTest() {
      InitializeComponent();
    }

    public void HandleData(object sender, clsLocalDrivingLicense LDL, clsTestType TestType) {
      _LDL = LDL;
      _TestType = TestType;

      _LoadData();
    }

    private void cntrlScheduleTest_Load(object sender,
                                        EventArgs e) {
    }

    private void btSave_Click(object sender, EventArgs e) {
      clsTestAppointment testAppointment = new clsTestAppointment();
      testAppointment.LocalDrivingLicenseApplicationID = _LDL.LocalDrivingLicenseApplicationID;
      testAppointment.TestTypeID = _TestType.TestTypeID;
      testAppointment.CreatedByUserID = GlobalState.LogedInUser.UserID;
      testAppointment.PaidFees = _TestType.TestTypeFess;
      testAppointment.AppointmentDate = dtpDate.Value;
      testAppointment.IsLocked = false;

      if(testAppointment.Save()) {
        MessageBox.Show("Appointment saved successfully");
      } else {
        MessageBox.Show("Error saving Appointment");
      }
    }
  }
}
