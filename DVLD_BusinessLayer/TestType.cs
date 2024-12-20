using DVLD_AccessLayer;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsTestType {
    public int TestTypeID { get; set; }
    public string TestTypeTitle { get; set; }
    public string TestTypeDescription { get; set; }
    public decimal TestTypeFess { get; set; }

    public clsTestType(int testid, string title, string description,
                       decimal fees) {
      this.TestTypeID = testid;
      this.TestTypeTitle = title;
      this.TestTypeDescription = description;
      this.TestTypeFess = fees;
    }

    private bool _UpdateTestType() {
      return clsTestTypeDataAccessLayer.UpdateTestType(
          this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription,
          this.TestTypeFess);
    }

    public bool Save() { return _UpdateTestType(); }

    public static clsTestType Find(int TestTypeID) {
      string Title = "";
      string description = "";
      decimal Fees = 0;

      if(clsTestTypeDataAccessLayer.GetTestTypeInfoByID(
              TestTypeID, ref Title, ref description, ref Fees)) {
        return new clsTestType(TestTypeID, Title, description, Fees);
      } else {
        return null;
      }
    }

    public static DataTable GetAllTestTypes() {
      return clsTestTypeDataAccessLayer.GetAllTestTypes();
    }

    public static bool IsTestTypeExist(int TestTypeID) {
      return clsTestTypeDataAccessLayer.IsTestTypeExist(TestTypeID);
    }
  }
}
