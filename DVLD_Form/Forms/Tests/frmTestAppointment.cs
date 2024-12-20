using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Tests {
  public partial class frmTestAppointment : Form {
    //----------------------------------------------------
    private BindingSource _source = new BindingSource();

    public delegate void DataBackEventHandler(
      object sender, clsLocalDrivingLicense _LDL);
    public event DataBackEventHandler DataBack;

    private clsLocalDrivingLicense _LDL;
    private int _LDLID;
    private int _TestType;

    //----------------------------------------------------
    private void _RaiseEvent() {
      DataBack?.Invoke(this, _LDL);
    }

    private void _LoadUsersData() {
      _source.DataSource =
        clsTestAppointment.GetAllTestAppointments();
      dataGridView1.DataSource = _source;

      _source.Filter = $"TestTypeID = {_TestType} AND  LocalDrivingLicenseApplicationID = {_LDLID}";
    }

    //----------------------------------------------------
    public frmTestAppointment(int LDLID, int TestType) {
      InitializeComponent();

      _LDLID = LDLID;
      _TestType = TestType;

      DataBack += cntrlVisionTestAppointment1.HandleData;
    }

    private void VisionTestAppointment_Load(object sender,
      EventArgs e) {
      switch(_TestType) {
        case 1:
        lbHeader.Text = "Vision Test";
        this.Text = "Vision Test";
        break;
        case 2:
        lbHeader.Text = "Written Test";
        this.Text = "Written Test";
        break;
        case 3:
        lbHeader.Text = "Street Test";
        this.Text = "Street Test";
        break;
      }

      _LDL = clsLocalDrivingLicense.Find(_LDLID);

      _LoadUsersData();
      _RaiseEvent();
    }

    private void takeTestToolStripMenuItem_Click(object sender, EventArgs e) {
      frmTakeTestForm take = new frmTakeTestForm(((int)dataGridView1.CurrentRow.Cells[0].Value));
      take.ShowDialog();

      _LoadUsersData();
    }

    private void button2_Click(object sender, EventArgs e) {
      frmScheduleTestForm scheduleTestForm =
        new frmScheduleTestForm(_TestType);
      DataBack += scheduleTestForm.HandleData;

      _RaiseEvent();
      scheduleTestForm.ShowDialog();

      _LoadUsersData();
    }

    private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
      if((bool)dataGridView1.CurrentRow.Cells[6].Value == true) {
        takeTestToolStripMenuItem.Enabled = false;
      } else {
        takeTestToolStripMenuItem.Enabled = true;
      }
    }
  }
}
