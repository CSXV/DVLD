using DVLD_AccessLayer;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsUser {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode = new enMode();

    public int UserID { get; set; }
    public int PersonID { get; set; }
    public string UserName { get; set; }
    public bool IsActive { get; set; }
    public string Password { get; set; }

    public clsPerson PersonInfo;

    public clsUser() {
      this.UserID = -1;
      this.PersonID = -1;
      this.UserName = "";
      this.Password = "";
      this.IsActive = false;

      _Mode = enMode.AddNew;
    }

    public clsUser(int userID, int personID, string userName, bool isActive, string Password) {
      this.UserID = userID;
      this.PersonID = personID;
      this.UserName = userName;
      this.IsActive = isActive;
      this.Password = Password;
      this.PersonInfo = clsPerson.Find(personID);

      _Mode = enMode.Update;
    }

    private bool _AddNewUser() {
      this.Password = clsUtilites.ComputeHash(this.Password);

      this.UserID = clsUserDataAccessLayer.AddUser(this.PersonID, this.UserName, this.IsActive, this.Password);
      return (this.UserID != -1);
    }

    private bool _UpdateUser() {
      this.Password = clsUtilites.ComputeHash(this.Password);

      return clsUserDataAccessLayer.UpdateUser(this.UserID, this.PersonID, this.UserName, this.IsActive, this.Password);
    }

    public bool Save() {
      switch(_Mode) {
        case enMode.AddNew:
        if(_AddNewUser()) {
          _Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdateUser();
      }

      return false;
    }

    public static clsUser Find(int UserID) {
      int PersonID = -1;
      string UserName = "";
      string Password = "";
      bool IsActive = false;

      if(clsUserDataAccessLayer.GetUserInfoByID(
              UserID, ref PersonID, ref UserName, ref IsActive, ref Password)) {
        return new clsUser(UserID, PersonID, UserName, IsActive, Password);
      } else {
        return null;
      }
    }

    public static clsUser Find(string UserName) {
      int UserID = -1;
      int PersonID = -1;
      bool IsActive = false;
      string Password = "";

      if(clsUserDataAccessLayer.GetUserInfoByName(
              ref UserID, ref PersonID, UserName, ref IsActive, ref Password)) {
        return new clsUser(UserID, PersonID, UserName, IsActive, Password);
      } else {
        return null;
      }
    }

    public static DataTable GetAllUsers() {
      return clsUserDataAccessLayer.GetAllUsers();
    }

    public static bool IsUserExist(int UserID) {
      return clsUserDataAccessLayer.IsUserExist(UserID);
    }

    public static bool IsUserExist(string UserName) {
      return clsUserDataAccessLayer.IsUserExist(UserName);
    }

    public static bool DeleteUser(int UserID) {
      return clsUserDataAccessLayer.DeleteUser(UserID);
    }

    public static bool DeleteUser(string UserName) {
      return clsUserDataAccessLayer.DeleteUser(UserName);
    }
  }
}
