using DVLD_AccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsDetain {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int DetainID { get; set; }
    public int LicenseID { get; set; }
    public DateTime DetainDate { get; set; }
    public decimal FineFees { get; set; }
    public int CreatedByUserID { get; set; }
    public bool IsReleased { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int? ReleasedByUserID { get; set; }
    public int ReleaseApplicationID { get; set; }

    public clsLicense LicenseInfo;

    public clsDetain() {
      this.DetainID = -1;
      this.LicenseID = -1;
      this.DetainDate = DateTime.Now;
      this.FineFees = -1;
      this.CreatedByUserID = -1;
      this.IsReleased = false;
      this.ReleaseDate = DateTime.Now;
      this.ReleasedByUserID = -1;
      this.ReleaseApplicationID = -1;

      _Mode = enMode.AddNew;
    }

    public clsDetain(int detainid, int licenseid, DateTime detaintime,
      decimal finefees, int createdbyuserid, bool isreleased,
      DateTime releaseddate, int releasedbyuserid, int raID) {
      this.DetainID = detainid;
      this.LicenseID = licenseid;
      this.DetainDate = detaintime;
      this.FineFees = finefees;
      this.CreatedByUserID = createdbyuserid;
      this.IsReleased = isreleased;
      this.ReleaseDate = releaseddate;
      this.ReleasedByUserID = releasedbyuserid;
      this.ReleaseApplicationID = raID;

      this.LicenseInfo = clsLicense.Find(licenseid);

      _Mode = enMode.Update;
    }

    public static clsDetain Find(int DetainID) {
      int LicenseID = -1;
      DateTime DetainTime = DateTime.Now;
      decimal FineFees = -1;
      int CreatedByUserID = -1;
      bool IsReleased = false;
      DateTime ReleaseDate = DateTime.Now;
      int ReleasedByUserID = -1;
      int ReleaseApplicationID = -1;

      if(clsDetainDataAccessLayer.GetDetainInfoByID(
              DetainID, ref LicenseID, ref DetainTime,
              ref FineFees, ref CreatedByUserID, ref IsReleased,
              ref ReleaseDate, ref ReleasedByUserID,
              ref ReleaseApplicationID)) {
        return new clsDetain(DetainID, LicenseID, DetainTime, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
      } else {
        return null;
      }
    }

    public static clsDetain FindByLicenseID(int LicenseID) {
      int DetainID = -1;
      DateTime DetainTime = DateTime.Now;
      decimal FineFees = -1;
      int CreatedByUserID = -1;
      bool IsReleased = false;
      DateTime ReleaseDate = DateTime.Now;
      int ReleasedByUserID = -1;
      int ReleaseApplicationID = -1;

      if(clsDetainDataAccessLayer.GetDetainInfoByLicenseID(
              ref DetainID, LicenseID, ref DetainTime,
              ref FineFees, ref CreatedByUserID, ref IsReleased,
              ref ReleaseDate, ref ReleasedByUserID,
              ref ReleaseApplicationID)) {
        return new clsDetain(DetainID, LicenseID, DetainTime, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
      } else {
        return null;
      }
    }

    private bool _AddNewDetain() {
      this.DetainID = clsDetainDataAccessLayer.AddDetain(
          this.LicenseID, this.DetainDate, this.FineFees,
          this.CreatedByUserID);

      return (this.DetainID != -1);
    }

    private bool _UpdateDetain() {
      return clsDetainDataAccessLayer.UpdateDetain(
          this.DetainID, this.LicenseID, this.DetainDate, this.FineFees,
          this.CreatedByUserID, this.IsReleased, this.ReleaseDate,
          this.ReleasedByUserID, this.ReleaseApplicationID);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewDetain()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateDetain();
      }

      return false;
    }

    public static DataTable GetAllDetains() {
      return clsDetainDataAccessLayer.GetAllDetains();
    }

    public static bool IsDetainExist(int DetainID) {
      return clsDetainDataAccessLayer.IsDetainExist(DetainID);
    }

    public static bool IsDetainExistByLicenseID(int LicenseID) {
      return clsDetainDataAccessLayer.IsDetainExistByLicenseID(LicenseID);
    }

    public static bool IsActiveDetainExistByLicenseID(int LicenseID) {
      return clsDetainDataAccessLayer.IsActiveDetainExistByLicenseID(LicenseID);
    }

    public static bool DeleteDetain(int DetainID) {
      return clsDetainDataAccessLayer.DeleteDetain(DetainID);
    }
  }
}
