using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmLicenseHistoryForm : Form {
    BindingSource _source = new BindingSource();
    BindingSource _sourceInt = new BindingSource();
    private clsDriver _Driver;
    private string _NatNo;
    private int _DriverID;

    public frmLicenseHistoryForm(string NatNo) {
      InitializeComponent();
      _NatNo = NatNo;
    }

    public frmLicenseHistoryForm(int DriverID) {
      InitializeComponent();
      _DriverID = DriverID;
    }

    private void _LoadPersonInfo() {
      _Driver = new clsDriver();
      _Driver.PersonInfo = clsPerson.Find(_NatNo);
    }

    private void _LoadDriverInfo() {
      if(_Driver.PersonInfo != null) {
        _Driver = clsDriver.FindByPersonID(_Driver.PersonInfo.PersonID);
      } else {
        _Driver = clsDriver.Find(_DriverID);
      }
    }

    private void _LoadData() {
      _source.DataSource = clsLicense.GetAllLicenses();
      _sourceInt.DataSource = clsInternationalLicense.GetAllInternationalLicenses();

      if(_Driver == null) {
        cntrlDriverLicenses1.DisableLocalDataGridView();
      } else {
        _source.Filter = $"DriverID = {_Driver.DriverID}";
        cntrlDriverLicenses1.SetLocalDataGridViewDataSource(_source);
      }

      if(_Driver == null) {
        cntrlDriverLicenses1.DisableInternationalDataGridView();
      } else {
        _sourceInt.Filter = $"DriverID = {_Driver.DriverID}";
        cntrlDriverLicenses1.SetInternationalDataGridViewDataSource(_sourceInt);
      }

      cntrlPersonInfo1.SetID(_Driver.PersonInfo.PersonID);
      cntrlPersonInfo1.UpdateControl();
    }

    private void LicenseHistoryForm_Load(object sender, System.EventArgs e) {
      _LoadPersonInfo();
      _LoadDriverInfo();
      _LoadData();
    }
  }
}
