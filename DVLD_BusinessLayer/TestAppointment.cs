using DVLD_AccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsTestAppointment {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int TestAppointmentID { get; set; }
    public int TestTypeID { get; set; }
    public int LocalDrivingLicenseApplicationID { get; set; }
    public DateTime AppointmentDate { get; set; }
    public decimal PaidFees { get; set; }
    public int CreatedByUserID { get; set; }
    public bool IsLocked { get; set; }

    public clsTestType TestTypeInfo;
    public clsLocalDrivingLicense LDLinfo;

    public clsTestAppointment() {
      this.TestAppointmentID = -1;
      this.TestTypeID = -1;
      this.LocalDrivingLicenseApplicationID = -1;
      this.AppointmentDate = DateTime.Now;
      this.PaidFees = -1;
      this.CreatedByUserID = -1;
      this.IsLocked = false;

      _Mode = enMode.AddNew;
    }

    public clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked) {
      this.TestAppointmentID = TestAppointmentID;
      this.TestTypeID = TestTypeID;
      this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
      this.AppointmentDate = AppointmentDate;
      this.PaidFees = PaidFees;
      this.CreatedByUserID = CreatedByUserID;
      this.IsLocked = IsLocked;

      this.TestTypeInfo = clsTestType.Find(TestTypeID);
      this.LDLinfo = clsLocalDrivingLicense.Find(LocalDrivingLicenseApplicationID);

      _Mode = enMode.Update;
    }

    public static DataTable GetAllTestAppointments() {
      return clsTestAppointmentDataAccessLayer.GetAllTestAppointments();
    }

    private bool _AddNewTestAppointment() {
      this.TestAppointmentID =
        clsTestAppointmentDataAccessLayer.AddTestAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);

      return (this.TestAppointmentID != -1);
    }

    private bool _UpdateTestAppointment() {
      return clsTestAppointmentDataAccessLayer.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewTestAppointment()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateTestAppointment();
      }

      return false;
    }

    public static clsTestAppointment Find(int TestAppointmentID) {
      int TestTypeID = -1;
      int LocalDrivingLicenseApplicationID = -1;
      DateTime AppointmentDate = DateTime.Now;
      decimal PaidFees = -1;
      int CreatedByUserID = -1;
      bool IsLocked = false;

      if(clsTestAppointmentDataAccessLayer.GetTestAppointmentsByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked)) {
        return new clsTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
      } else {
        return null;
      }
    }
  }
}
