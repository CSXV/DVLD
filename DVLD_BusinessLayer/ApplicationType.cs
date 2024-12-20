using DVLD_AccessLayer;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsApplicationType {
    public int ApplicationTypeID { get; set; }
    public string ApplicationTypeTitle { get; set; }
    public decimal ApplicationFees { get; set; }

    public clsApplicationType(int AppTypeID, string Title, decimal Fees) {
      this.ApplicationTypeID = AppTypeID;
      this.ApplicationTypeTitle = Title;
      this.ApplicationFees = Fees;
    }

    private bool _UpdateAppType() {
      return clsApplicationTypeDataAccessLayer.UpdateApplicationType(
          this.ApplicationTypeID, this.ApplicationTypeTitle,
          this.ApplicationFees);
    }

    public bool Save() { return _UpdateAppType(); }

    public static clsApplicationType Find(int AppTypeID) {
      string Title = "";
      decimal Fees = 0;

      if(clsApplicationTypeDataAccessLayer.GetAppTypeInfoByID(
              AppTypeID, ref Title, ref Fees)) {
        return new clsApplicationType(AppTypeID, Title, Fees);
      } else {
        return null;
      }
    }

    public static DataTable GetAllApplicationTypes() {
      return clsApplicationTypeDataAccessLayer.GetAllApplicationTypes();
    }

    public static bool IsApplicationTypeExist(int AppTypeID) {
      return clsApplicationTypeDataAccessLayer.IsAppTypeExist(AppTypeID);
    }
  }
}
