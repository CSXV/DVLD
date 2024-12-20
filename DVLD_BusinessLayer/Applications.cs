using DVLD_AccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsApplications {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int ApplicationID { get; set; }
    public int ApplicationPersonID { get; set; }
    public DateTime ApplicationDate { get; set; }
    public int ApplicationTypeID { get; set; }
    public byte ApplicationStatus { get; set; }
    public DateTime LastStautsDate { get; set; }
    public decimal PaidFees { get; set; }
    public int CreatedByUserID { get; set; }

    public clsApplicationType ApplicationTypeInfo;
    public clsPerson ApplicantPersonInfo;
    public clsUser UserInfo;

    public clsApplications() {
      this.ApplicationID = -1;
      this.ApplicationPersonID = -1;
      this.ApplicationDate = DateTime.Now;
      this.ApplicationTypeID = -1;
      this.ApplicationStatus = 0;
      this.LastStautsDate = DateTime.Now;
      this.PaidFees = -1;
      this.CreatedByUserID = -1;

      _Mode = enMode.AddNew;
    }

    public clsApplications(int AppID, int AppPersonID, DateTime AppDate, int AppTypeID, byte AppStatus, DateTime AppLastStatus, decimal PaidFees, int CreatedByUserID) {
      this.ApplicationID = AppID;
      this.ApplicationPersonID = AppPersonID;
      this.ApplicationDate = AppDate;
      this.ApplicationTypeID = AppTypeID;
      this.ApplicationStatus = AppStatus;
      this.LastStautsDate = AppLastStatus;
      this.PaidFees = PaidFees;
      this.CreatedByUserID = CreatedByUserID;

      this.ApplicationTypeInfo = clsApplicationType.Find(AppTypeID);
      this.UserInfo = clsUser.Find(CreatedByUserID);
      this.ApplicantPersonInfo = clsPerson.Find(ApplicationPersonID);

      _Mode = enMode.Update;
    }

    public static clsApplications Find(int AppID) {
      int ApplicationPersonID = -1;
      DateTime ApplicationDate = DateTime.Now;
      int ApplicationTypeID = -1;
      byte ApplicationStatus = 0;
      DateTime LastStautsDate = DateTime.Now;
      decimal PaidFees = -1;
      int CreatedByUserID = -1;

      if(clsApplicationsDataAccessLayer.GetApplicationInfoByID(
              AppID, ref ApplicationPersonID, ref ApplicationDate,
              ref ApplicationTypeID, ref ApplicationStatus, ref LastStautsDate,
              ref PaidFees, ref CreatedByUserID)) {
        return new clsApplications(AppID, ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStautsDate, PaidFees, CreatedByUserID);
      } else {
        return null;
      }
    }

    private bool _AddNewApplication() {
      this.ApplicationID = clsApplicationsDataAccessLayer.AddApplication(
          this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID,
          this.ApplicationStatus, this.LastStautsDate, this.PaidFees,
          this.CreatedByUserID);

      return (this.ApplicationID != -1);
    }

    private bool _UpdateApplication() {
      return clsApplicationsDataAccessLayer.UpdateApplication(
          this.ApplicationID, this.ApplicationPersonID, this.ApplicationDate,
          this.ApplicationTypeID, this.ApplicationStatus, this.LastStautsDate,
          this.PaidFees, this.CreatedByUserID);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewApplication()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateApplication();
      }

      return false;
    }

    public static DataTable GetAllApplications() {
      return clsApplicationsDataAccessLayer.GetAllApplications();
    }

    public static bool IsApplicationExist(int AppID) {
      return clsApplicationsDataAccessLayer.IsApplicationExist(AppID);
    }

    public static bool IsApplicationExistByPersonID(int PersonID, int AppTypeID) {
      return clsApplicationsDataAccessLayer.IsApplicationExistByPersonAndType(
          PersonID, AppTypeID);
    }

    public static bool DeleteApplication(int AppID) {
      return clsApplicationsDataAccessLayer.DeleteApplication(AppID);
    }

    public static bool CancelApplication(int AppID) {
      return clsApplicationsDataAccessLayer.CancelApplication(AppID);
    }
  }
}
