using DVLD_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Form.Forms.Applications {
  public partial class frmNewLocalDrivingLicenseApplication : Form {
    // Delegate
    // ---------------------------------------------
    public delegate void DataBackEventHandler(object sender, int PersonID);

    public event DataBackEventHandler DataBackUserMain;

    // Variables
    // ---------------------------------------------
    BindingSource _source = new BindingSource();

    private clsPerson _Person = new clsPerson();
    private clsLicenseClasses _LicenseClasses = new clsLicenseClasses();
    private clsApplicationType _AppType = clsApplicationType.Find(1);
    private clsLicenseClasses _Class;
    private clsLocalDrivingLicense _LDL = new clsLocalDrivingLicense();

    // Functions
    // ---------------------------------------------
    public frmNewLocalDrivingLicenseApplication() {
      InitializeComponent();

      lbCreatedBy.Text = GlobalState.LogedInUser.UserName;

      cntrlSearchBox1.DataBack += cntrlPersonInfo1.HandleData;
      cntrlSearchBox1.DataBack += _SetPersonID;
    }

    public void RaiseEvent() {
      DataBackUserMain?.Invoke(this, _Person.PersonID);
    }

    // ______________________
    private void _SetPersonID(object sender, int PersonID) {
      this._Person = clsPerson.Find(PersonID);
    }

    public void UpdateControl() {
      cntrlPersonInfo1.SetID(_Person.PersonID);
      cntrlPersonInfo1.UpdateControl();
    }

    private void _LoadLicenseClasses() {
      _source.DataSource = clsLicenseClasses.GetAllLicenseClasses();
    }

    private void NewLocalDrivingLicenseApplication_Load(object sender, EventArgs e) {
      UpdateControl();
      _LoadLicenseClasses();

      cbLicenseClass.DataSource = _source;
      cbLicenseClass.DisplayMember = "ClassName";
      cbLicenseClass.SelectedIndex = 2;
      lbApplicationDate.Text = DateTime.Now.ToString();
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
      RaiseEvent();
    }

    private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e) {
      _Class = clsLicenseClasses.Find(cbLicenseClass.SelectedIndex + 1);
      lbApplicationFees.Text = _AppType.ApplicationFees.ToString();
    }

    private bool _CheckAge() {
      DataTable table = (DataTable)_source.DataSource;
      int personage = DateTime.Now.Year - _Person.DateOfBirth.Year;

      foreach(DataRow row in table.Rows) {
        if(int.TryParse(row["MinimumAllowedAge"].ToString(), out int dateValue)) {
          if(dateValue > personage) {
            MessageBox.Show("Person is below minimum age of this license class");
            btSave.Enabled = false;
            return true;
          }
        }
      }

      return false;
    }

    private bool _CheckIfHadLicense() {
      if(clsApplications.IsApplicationExistByPersonID(_Person.PersonID, 1)) {
        MessageBox.Show("Error: Person Already had an Application with this type of license.");
        return true;
      }

      return false;
    }

    private void btSave_Click(object sender, EventArgs e) {
      if(_CheckAge() /*|| _CheckIfHadLicense()*/) {
        return;
      }

      clsApplications app = new clsApplications();

      app.ApplicationPersonID = _Person.PersonID;
      app.ApplicationDate = DateTime.Now;
      app.ApplicationTypeID = _AppType.ApplicationTypeID;
      app.ApplicationStatus = 1;
      app.LastStautsDate = DateTime.Now;
      app.PaidFees = _AppType.ApplicationFees;
      app.CreatedByUserID = GlobalState.LogedInUser.UserID;

      if(app.Save()) {
        _LDL.LicenseClassID = cbLicenseClass.SelectedIndex + 1;
        _LDL.ApplicationID = app.ApplicationID;

        if(_LDL.Save()) {
          MessageBox.Show("Application saved successfully");
        } else {
          MessageBox.Show("Error saving License");
        }
      } else {
        MessageBox.Show("Error saving Application");
      }

      lbDLA_ID.Text = _LDL.LocalDrivingLicenseApplicationID.ToString();
    }

    private void btNext_Click(object sender, EventArgs e) {
      tabControl1.SelectedIndex = 1;
      RaiseEvent();
    }
  }
}
