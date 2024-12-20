using DVLD_AccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsDriver {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int DriverID { get; set; }
    public int PersonID { get; set; }
    public int CreatedByUserID { get; set; }
    public DateTime CreatedDate { get; set; }

    public clsPerson PersonInfo;

    public clsDriver() {
      this.DriverID = -1;
      this.PersonID = -1;
      this.CreatedByUserID = -1;
      this.CreatedDate = DateTime.Now;

      _Mode = enMode.AddNew;
    }

    public clsDriver(int driverid, int personid, int createdbyuserid,
                     DateTime createddate) {
      this.DriverID = driverid;
      this.PersonID = personid;
      this.CreatedByUserID = createdbyuserid;
      this.CreatedDate = createddate;
      this.PersonInfo = clsPerson.Find(personid);

      _Mode = enMode.Update;
    }

    private bool _AddNewDriver() {
      this.DriverID = clsDriverDataAccessLayer.AddDriver(
          this.PersonID, this.CreatedByUserID, this.CreatedDate);

      return (this.DriverID != -1);
    }

    private bool _UpdateDriver() {
      return clsDriverDataAccessLayer.UpdateDriver(
          this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewDriver()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateDriver();
      }

      return false;
    }

    public static clsDriver Find(int DriverID) {
      int PersonID = -1;
      int CreatedByUserID = -1;
      DateTime CreatedDate = DateTime.Now;

      if(clsDriverDataAccessLayer.GetDriverInfoByID(
              DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate)) {
        return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
      } else {
        return null;
      }
    }

    public static clsDriver FindByPersonID(int PersonID) {
      int DriverID = -1;
      int CreatedByUserID = -1;
      DateTime CreatedDate = DateTime.Now;

      if(clsDriverDataAccessLayer.GetDriverInfoByPersonID(
              ref DriverID, PersonID, ref CreatedByUserID, ref CreatedDate)) {
        return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
      } else {
        return null;
      }
    }

    public static DataTable GetAllDrivers() {
      return clsDriverDataAccessLayer.GetAllDrivers();
    }

    public static DataTable GetAllDriversTable() {
      return clsDriverDataAccessLayer.GetAllDriversTable();
    }

    public static bool IsDriverExist(int DriverID) {
      return clsDriverDataAccessLayer.IsDriverExist(DriverID);
    }

    public static bool IsDriverExistByPersonID(int PersonID) {
      return clsDriverDataAccessLayer.IsDriverExistByPersonID(PersonID);
    }

    public static bool DeleteDriver(int DriverID) {
      return clsDriverDataAccessLayer.DeleteDriver(DriverID);
    }

    public static bool DeleteDriverByPersonID(int PersonID) {
      return clsDriverDataAccessLayer.DeleteDriverByPersonID(PersonID);
    }
  }
}
