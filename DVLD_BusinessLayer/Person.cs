using DVLD_AccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer {
  public class clsPerson {
    public enum enMode { AddNew = 0, Update = 1 }
    enMode Mode = new enMode();

    public int PersonID { set; get; }
    public string FirstName { set; get; }
    public string SecondName { set; get; }
    public string ThirdName { set; get; }
    public string LastName { set; get; }
    public string NationalNo { set; get; }
    public byte Gendor { set; get; }
    public DateTime DateOfBirth { set; get; }
    public string Address { set; get; }
    public string Phone { set; get; }
    public string Email { set; get; }
    public string ImagePath { set; get; }
    public int NationailtyCountryID { set; get; }
    public string FullName() {
      return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
    }

    public clsCountry CountryInfo;

    // --------------------------------------------
    public clsPerson() {
      this.PersonID = -1;
      this.FirstName = "";
      this.SecondName = "";
      this.ThirdName = "";
      this.LastName = "";
      this.NationalNo = "";
      this.Gendor = 0;
      this.DateOfBirth = DateTime.Now;
      this.Address = "";
      this.Phone = "";
      this.Email = "";
      this.ImagePath = "";
      this.NationailtyCountryID = -1;

      Mode = enMode.AddNew;
    }

    public clsPerson(int personID, string firstName, string secondName, string thirdName, string lastName, string nationalNo, byte gendor, DateTime dateOfBirth, string address, string phone, string email, string imagePath, int nationailtyCountryID) {
      this.PersonID = personID;
      this.FirstName = firstName;
      this.SecondName = secondName;
      this.ThirdName = thirdName;
      this.LastName = lastName;
      this.NationalNo = nationalNo;
      this.Gendor = gendor;
      this.DateOfBirth = dateOfBirth;
      this.Address = address;
      this.Phone = phone;
      this.Email = email;
      this.ImagePath = imagePath;
      this.NationailtyCountryID = nationailtyCountryID;
      this.CountryInfo = clsCountry.Find(NationailtyCountryID);

      Mode = enMode.Update;
    }

    private bool _AddNewPerson() {
      this.PersonID = clsPersonDataAccessLayer.AddPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.Gendor, this.Email, this.Phone, this.Address, this.DateOfBirth, this.NationailtyCountryID, this.ImagePath);

      return (this.PersonID != -1);
    }

    private bool _UpdatePerson() {
      return clsPersonDataAccessLayer.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.Gendor, this.Email, this.Phone, this.Address, this.DateOfBirth, this.NationailtyCountryID, this.ImagePath);
    }

    public bool Save() {
      switch(Mode) {
        case enMode.AddNew:
        if(_AddNewPerson()) {
          Mode = enMode.Update;
          return true;
        } else {
          return false;
        }
        case enMode.Update:
        return _UpdatePerson();
      }

      return false;
    }

    public static clsPerson Find(int PersonID) {
      string FirstName = "";
      string SecondName = "";
      string ThirdName = "";
      string LastName = "";
      string NationalNo = "";
      byte Gendor = 0;
      DateTime DateOfBrith = DateTime.Now;
      string Address = "";
      string Phone = "";
      string Email = "";
      string ImagePath = "";
      int NationailtyCountryID = -1;

      if(clsPersonDataAccessLayer.GetPersonInfoByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo, ref Gendor, ref Email, ref Phone, ref Address, ref DateOfBrith, ref NationailtyCountryID, ref ImagePath)) {
        return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, Gendor, DateOfBrith, Address, Phone, Email, ImagePath, NationailtyCountryID);
      } else {
        return null;
      }
    }

    public static clsPerson Find(string NationalNo) {
      int PersonID = -1;
      string FirstName = "";
      string SecondName = "";
      string ThirdName = "";
      string LastName = "";
      byte Gendor = 0;
      DateTime DateOfBrith = DateTime.Now;
      string Address = "";
      string Phone = "";
      string Email = "";
      string ImagePath = "";
      int NationailtyCountryID = -1;

      if(clsPersonDataAccessLayer.GetPersonInfoByNationalNo(ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, NationalNo, ref Gendor, ref Email, ref Phone, ref Address, ref DateOfBrith, ref NationailtyCountryID, ref ImagePath)) {
        return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, Gendor, DateOfBrith, Address, Phone, Email, ImagePath, NationailtyCountryID);
      } else {
        return null;
      }
    }

    public static DataTable GetAllPeople() {
      return clsPersonDataAccessLayer.GetAllPeople();
    }

    public static bool IsPersonExist(int PersonID) {
      return clsPersonDataAccessLayer.IsPersonExist(PersonID);
    }

    public static bool IsPersonExist(string NationalNo) {
      return clsPersonDataAccessLayer.IsPersonExist(NationalNo);
    }

    public static bool DeletePerson(int PersonID) {
      return clsPersonDataAccessLayer.DeletePerson(PersonID);
    }

    public static bool DeletePerson(string NationalNo) {
      return clsPersonDataAccessLayer.DeletePerson(NationalNo);
    }

  }
}
