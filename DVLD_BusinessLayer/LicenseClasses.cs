using DVLD_AccessLayer;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsLicenseClasses {
    public int LicenseClassID { get; set; }
    public string ClassName { get; set; }
    public string ClassDescription { get; set; }
    public byte MinimumAllowedAge { get; set; }
    public byte DefaultValidityLength { get; set; }
    public decimal ClassFees { get; set; }

    public clsLicenseClasses() {
      this.LicenseClassID = -1;
      this.ClassName = "";
      this.ClassDescription = "";
      this.MinimumAllowedAge = 0;
      this.DefaultValidityLength = 0;
      this.ClassFees = -1;
    }

    public clsLicenseClasses(int LCID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees) {
      this.LicenseClassID = LCID;
      this.ClassName = ClassName;
      this.ClassDescription = ClassDescription;
      this.MinimumAllowedAge = MinimumAllowedAge;
      this.DefaultValidityLength = DefaultValidityLength;
      this.ClassFees = ClassFees;
    }

    public static clsLicenseClasses Find(int LCID) {
      string ClassName = "";
      string ClassDescription = "";
      byte MinimumAllowedAge = 0;
      byte DefaultValidityLength = 0;
      decimal ClassFees = -1;

      if(clsLicenseClassDataAccessLayer.GetLicenseClassInfoByID(LCID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees)) {
        return new clsLicenseClasses(LCID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
      } else {
        return null;
      }
    }

    public static DataTable GetAllLicenseClasses() {
      return clsLicenseClassDataAccessLayer.GetAllLicensesTable();
    }
  }
}
