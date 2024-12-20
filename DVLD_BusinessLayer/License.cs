using DVLD_AccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsLicense {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int LicenseID { get; set; }
    public int ApplicationID { get; set; }
    public int DriverID { get; set; }
    public int LicenseClass { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Notes { get; set; }
    public decimal PaidFees { get; set; }
    public bool IsActive { get; set; }
    public byte IssueReason { get; set; }
    public int CreatedByUserID { get; set; }

    public clsDriver DriverInfo;
    public clsApplications ApplicationInfo;
    public clsLicenseClasses LicenseClassesInfo;

    public clsLicense() {
      this.LicenseID = -1;
      this.ApplicationID = -1;
      this.DriverID = -1;
      this.LicenseClass = -1;
      this.IssueDate = DateTime.Now;
      this.ExpirationDate = DateTime.Now;
      this.Notes = "";
      this.PaidFees = -1;
      this.IsActive = true;
      this.IssueReason = 1;
      this.CreatedByUserID = -1;

      _Mode = enMode.AddNew;
    }

    public clsLicense(int lincenseid, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpriationDate, string notes, decimal paidfees, bool isactive, byte reason, int createdbyuserid) {
      this.LicenseID = lincenseid;
      this.ApplicationID = ApplicationID;
      this.DriverID = DriverID;
      this.LicenseClass = LicenseClass;
      this.IssueDate = IssueDate;
      this.ExpirationDate = ExpriationDate;
      this.Notes = notes;
      this.PaidFees = paidfees;
      this.IsActive = isactive;
      this.IssueReason = reason;
      this.CreatedByUserID = createdbyuserid;

      this.DriverInfo = clsDriver.Find(DriverID);
      this.ApplicationInfo = clsApplications.Find(ApplicationID);
      this.LicenseClassesInfo = clsLicenseClasses.Find(LicenseClass);

      _Mode = enMode.Update;
    }

    private bool _AddNewLicense() {
      this.LicenseID = clsLicenseDataAccessLayer.AddLicense(this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);

      return (this.LicenseID != -1);
    }

    private bool _UpdateLicense() {
      return clsLicenseDataAccessLayer.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
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

    public static clsLicense Find(int LicenseID) {
      int ApplicationID = -1;
      int DriverID = -1;
      int LicenseClass = -1;
      DateTime IssueDate = DateTime.Now;
      DateTime ExpirationDate = DateTime.Now;
      string Notes = "";
      decimal PaidFees = -1;
      bool IsActive = true;
      byte IssueReason = 1;
      int CreatedByUserID = -1;

      if(clsLicenseDataAccessLayer.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID)) {
        return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
      } else {
        return null;
      }
    }

    public static clsLicense FindByDriverID(int DriverID) {
      int LicenseID = -1;
      int ApplicationID = -1;
      int LicenseClass = -1;
      DateTime IssueDate = DateTime.Now;
      DateTime ExpirationDate = DateTime.Now;
      string Notes = "";
      decimal PaidFees = -1;
      bool IsActive = true;
      byte IssueReason = 1;
      int CreatedByUserID = -1;

      if(clsLicenseDataAccessLayer.GetLicenseInfoByPersonID(
ref LicenseID, ref ApplicationID, DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID)) {
        return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
      } else {
        return null;
      }
    }

    public static clsLicense FindByApplicationID(int ApplicationID) {
      int LicenseID = -1;
      int DriverID = -1;
      int LicenseClass = -1;
      DateTime IssueDate = DateTime.Now;
      DateTime ExpirationDate = DateTime.Now;
      string Notes = "";
      decimal PaidFees = -1;
      bool IsActive = true;
      byte IssueReason = 1;
      int CreatedByUserID = -1;

      if(clsLicenseDataAccessLayer.GetLicenseInfoByApplicationID(
ref LicenseID, ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID)) {
        return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
      } else {
        return null;
      }
    }

    public static bool IsLicenseExist(int LicenseID) {
      return clsLicenseDataAccessLayer.IsLicenseExist(LicenseID);
    }

    public static bool IsLicenseExistByDriverID(int PersonID) {
      return clsLicenseDataAccessLayer.IsLicenseExistByDriverID(PersonID);
    }

    public static DataTable GetAllLicenses() {
      return clsLicenseDataAccessLayer.GetAllLicenses();
    }

    public static bool DeleteLicense(int LicenseID) {
      return clsLicenseDataAccessLayer.DeleteLicense(LicenseID);
    }

    public static bool DeleteLicenseByDriverID(int PersonID) {
      return clsLicenseDataAccessLayer.DeleteLicenseByDriverID(PersonID);
    }

    public Boolean IsLicneseExpired() {
      return (this.ExpirationDate < DateTime.Now);
    }
  }
}
