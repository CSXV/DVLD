using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Tests {
  public partial class frmScheduleTestForm : Form {
    //----------------------------------------------------
    public delegate void DataBackEventHandler(
      object sender, clsLocalDrivingLicense _LDL, clsTestType _TestType);
    public event DataBackEventHandler DataBack;

    private clsLocalDrivingLicense _LDL;
    private clsTestType _TestType;

    //----------------------------------------------------
    private void _RaiseEvent() {
      DataBack?.Invoke(this, _LDL, _TestType);
    }

    //----------------------------------------------------
    public frmScheduleTestForm(int TestType) {
      InitializeComponent();
      _TestType = clsTestType.Find(TestType);

      DataBack += cntrlScheduleTest1.HandleData;
    }

    public void HandleData(object sender,
                           clsLocalDrivingLicense LDL) {
      _LDL = LDL;
    }

    private void ScheduleTestForm_Load(object sender,
                                       EventArgs e) {
      _RaiseEvent();
    }
  }
}
