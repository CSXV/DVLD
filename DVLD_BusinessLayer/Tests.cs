using DVLD_AccessLayer;

namespace DVLD_BusinessLayer {
  public class clsTests {
    private enum enMode { AddNew = 0, Update = 1 }
    enMode _Mode;
    public int TestID { get; set; }
    public int TestAppointmentID { get; set; }
    public bool TestResults { get; set; }
    public string Notes { get; set; }
    public int CreatedByUserID { get; set; }

    public clsTestAppointment TestAppointmentInfo;

    public clsTests() {
      this.TestID = -1;
      this.TestAppointmentID = -1;
      this.TestResults = false;
      this.Notes = "";
      this.CreatedByUserID = -1;

      _Mode = enMode.AddNew;
    }

    public clsTests(int testid, int TestAppointmentID, int CreatedByUserID, string notes, bool TestResults) {
      this.TestID = testid;
      this.TestAppointmentID = TestAppointmentID;
      this.TestResults = TestResults;
      this.Notes = notes;
      this.CreatedByUserID = CreatedByUserID;

      this.TestAppointmentInfo = clsTestAppointment.Find(TestAppointmentID);

      _Mode = enMode.Update;
    }

    private bool _AddNewTest() {
      this.TestID = clsTestsDataAccessLayer.AddTest(this.TestAppointmentID, this.TestResults, this.Notes, this.CreatedByUserID);

      return (this.TestID != -1);
    }

    private bool _UpdateTest() {
      return clsTestsDataAccessLayer.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResults, this.Notes, this.CreatedByUserID);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewTest()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateTest();
      }

      return false;
    }

    public clsTests Find(int TestID) {
      int TestAppointmentID = -1;
      bool TestResults = false;
      string Notes = "";
      int CreatedByUserID = -1;

      if(clsTestsDataAccessLayer.GetTestInfoByID(TestID, ref TestAppointmentID, ref TestResults, ref Notes, ref CreatedByUserID)) {
        return new clsTests(TestID, TestAppointmentID, CreatedByUserID, Notes, TestResults);
      } else {
        return null;
      }
    }
  }
}
