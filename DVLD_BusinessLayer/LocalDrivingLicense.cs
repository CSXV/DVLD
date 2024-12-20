using DVLD_AccessLayer;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsLocalDrivingLicense {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    public int LocalDrivingLicenseApplicationID { get; set; }
    public int ApplicationID { get; set; }
    public int LicenseClassID { get; set; }

    public clsApplications ApplicationInfo;
    public clsLicenseClasses LicenseClassInfo;

    // -------------------------------------------------
    public clsLocalDrivingLicense() {
      this.LocalDrivingLicenseApplicationID = -1;
      this.ApplicationID = -1;
      this.LicenseClassID = -1;

      _Mode = enMode.AddNew;
    }

    public clsLocalDrivingLicense(int LDLID, int AppID, int LCID) {
      this.LocalDrivingLicenseApplicationID = LDLID;
      this.ApplicationID = AppID;
      this.LicenseClassID = LCID;
      this.ApplicationInfo = clsApplications.Find(AppID);
      this.LicenseClassInfo = clsLicenseClasses.Find(LCID);

      _Mode = enMode.Update;
    }

    // -------------------------------------------------
    public static DataTable GetAllLocalDrivingLicenseApplication() {
      return clsLocalDrivingLicenseDataAccessLayer
          .GetAllLocalDrivingLicensesApplication();
    }

    private bool _AddNewLocalLicenseApp() {
      this.LocalDrivingLicenseApplicationID =
          clsLocalDrivingLicenseDataAccessLayer.AddLocalDrivingLicenseApplication(
              this.ApplicationID, this.LicenseClassID);

      return (this.ApplicationID != -1);
    }

    private bool _UpdateLocalLicenseApp() {
      return clsLocalDrivingLicenseDataAccessLayer.UpdateLocalLicenseApplication(
          this.LocalDrivingLicenseApplicationID, this.ApplicationID,
          this.LicenseClassID);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewLocalLicenseApp()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateLocalLicenseApp();
      }

      return false;
    }

    public static bool IsLocalDrivingLicenseExist(int PersonID) {
      return clsLocalDrivingLicenseDataAccessLayer.IsLocalDrivingLicenseExist(
          PersonID);
    }

    public static clsLocalDrivingLicense Find(int LDLID) {
      int ApplicationID = -1;
      int LicenseClassID = -1;

      if(clsLocalDrivingLicenseDataAccessLayer.GetLDLInfoByID(
              LDLID, ref ApplicationID, ref LicenseClassID)) {
        return new clsLocalDrivingLicense(LDLID, ApplicationID, LicenseClassID);
      } else {
        return null;
      }
    }

    public static bool CancelLocalDrivingLicenseAppliction(int LLAID) {
      clsLocalDrivingLicense App = clsLocalDrivingLicense.Find(LLAID);
      if(clsApplications.CancelApplication(App.ApplicationID)) {
        return true;
      } else {
        return false;
      }
    }

    public static bool DeleteLocalLicenseApplication(int LLAID) {
      int AppID = clsLocalDrivingLicenseDataAccessLayer.FindAppID(LLAID);

      if(clsLocalDrivingLicenseDataAccessLayer.DeleteLocalLicenseApplication(
              LLAID)) {

        if(AppID != -1) {
          if(clsApplications.DeleteApplication(AppID)) {
            return true;
          }
        }
      }

      return false;
    }

    public byte TotalTrialsPerTest(int TestTypeID) {
      return clsLocalDrivingLicenseDataAccessLayer.TotalTrialsPerTest(
          this.LocalDrivingLicenseApplicationID, TestTypeID);
    }

    public bool DoesAttendTestType(int TestTypeID) {
      return clsLocalDrivingLicenseDataAccessLayer.DoesAttendTestType(
          this.LocalDrivingLicenseApplicationID, TestTypeID);
    }
  }
}
