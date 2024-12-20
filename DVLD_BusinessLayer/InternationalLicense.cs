using DVLD_AccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsInternationalLicense {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int InternationalLicenseID { get; set; }
    public int ApplicationID { get; set; }
    public int DriverID { get; set; }
    public int IssuedUsingLocalLicenseID { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsActive { get; set; }
    public int CreatedByUserID { get; set; }

    public clsDriver DriverInfo;
    public clsLicense LicenseInfo;
    public clsApplications ApplicationInfo;

    public clsInternationalLicense() {
      this.InternationalLicenseID = -1;
      this.ApplicationID = -1;
      this.DriverID = -1;
      this.IssuedUsingLocalLicenseID = -1;
      this.IssueDate = DateTime.Now;
      this.ExpirationDate = DateTime.Now;
      this.IsActive = false;
      this.CreatedByUserID = -1;

      _Mode = enMode.AddNew;
    }

    public clsInternationalLicense(int ILID, int ApplicationID, int DriverID, int ILLID, DateTime issuedate, DateTime experationdate, bool isactive, int createdbyuserid) {
      this.InternationalLicenseID = ILID;
      this.ApplicationID = ApplicationID;
      this.DriverID = DriverID;
      this.IssuedUsingLocalLicenseID = ILLID;
      this.IssueDate = issuedate;
      this.ExpirationDate = experationdate;
      this.IsActive = isactive;
      this.CreatedByUserID = createdbyuserid;
      this.DriverInfo = clsDriver.Find(DriverID);
      this.LicenseInfo = clsLicense.Find(ILLID);
      this.ApplicationInfo = clsApplications.Find(ApplicationID);

      _Mode = enMode.Update;
    }

    private bool _AddNewLicense() {
      this.InternationalLicenseID = clsInternationalLicensesDataAccessLayer.AddLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
      return (this.InternationalLicenseID != -1);
    }

    private bool _UpdateLicense() {
      return clsInternationalLicensesDataAccessLayer.UpdateLicense(this.IssuedUsingLocalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate,
        this.ExpirationDate, this.IsActive, this.CreatedByUserID);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewLicense()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateLicense();
      }

      return false;
    }

    public static clsInternationalLicense Find(int InternationalLicenseID) {
      int ApplicationID = -1;
      int DriverID = -1;
      int IssuedUsingLocalLicenseID = -1;
      DateTime IssueDate = DateTime.Now;
      DateTime ExpirationDate = DateTime.Now;
      bool IsActive = false;
      int CreatedByUserID = -1;

      if(clsInternationalLicensesDataAccessLayer.GetIntLicenseInfoByID
(InternationalLicenseID, ref ApplicationID, ref DriverID,
ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
ref IsActive, ref CreatedByUserID)) {
        return new clsInternationalLicense(InternationalLicenseID,
          ApplicationID, DriverID, IssuedUsingLocalLicenseID,
          IssueDate, ExpirationDate, IsActive, CreatedByUserID);
      } else {
        return null;
      }
    }

    public static clsInternationalLicense FindByDriverID(int DriverID) {
      int InternationalLicenseID = -1;
      int ApplicationID = -1;
      int IssuedUsingLocalLicenseID = -1;
      DateTime IssueDate = DateTime.Now;
      DateTime ExpirationDate = DateTime.Now;
      bool IsActive = false;
      int CreatedByUserID = -1;

      if(clsInternationalLicensesDataAccessLayer.GetIntLicenseInfoByDriverID
(ref InternationalLicenseID, ref ApplicationID, DriverID,
ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate,
ref IsActive, ref CreatedByUserID)) {
        return new clsInternationalLicense(InternationalLicenseID,
          ApplicationID, DriverID, IssuedUsingLocalLicenseID,
          IssueDate, ExpirationDate, IsActive, CreatedByUserID);
      } else {
        return null;
      }
    }

    public static bool IsLicenseExist(int IntLicenseID) {
      return clsInternationalLicensesDataAccessLayer.IsLicenseExist(IntLicenseID);
    }

    public static bool IsLicenseExistByDriverID(int DriverID) {
      return clsInternationalLicensesDataAccessLayer.IsLicenseExistByDriverID(DriverID);
    }

    public static DataTable GetAllInternationalLicenses() {
      return clsInternationalLicensesDataAccessLayer.GetAllIntLicenses();
    }

    public static bool DeleteIntLicense(int IntLicenseID) {
      return clsInternationalLicensesDataAccessLayer.DeleteLicense(IntLicenseID);
    }

    public static bool DeleteIntLicenseByDriverID(int DriverID) {
      return clsInternationalLicensesDataAccessLayer.DeleteLicenseByDriverID(DriverID);
    }
  }
}
