using DVLD_AccessLayer;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsCountry {
    public int CountryID { get; set; }
    public string CountryName { get; set; }

    public clsCountry(int CountryID, string CountryName) {
      this.CountryID = CountryID;
      this.CountryName = CountryName;

    }

    public static clsCountry Find(string CountryName) {
      int CountryID = -1;

      if(clsCountryData.GetCountryInfoByName(ref CountryID, CountryName)) {
        return new clsCountry(CountryID, CountryName);
      } else {
        return null;
      }
    }

    public static clsCountry Find(int CountryID) {
      string CountryName = "";

      if(clsCountryData.GetCountryInfoByID(CountryID, ref CountryName)) {
        return new clsCountry(CountryID, CountryName);
      } else {
        return null;
      }
    }

    public static bool IsCountryExist(string CountryName) {
      return clsCountry.IsCountryExist(CountryName);
    }

    public static bool IsCountryExist(int CountryID) {
      return clsCountry.IsCountryExist(CountryID);
    }

    public static DataTable GetAllCountries() {
      return clsCountryData.GetAllCountries();
    }
  }
}
