using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsPersonDataAccessLayer {
    public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string NationalNo, ref byte Gendor, ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth, ref int NationalityCountryPersonID, ref string ImagePath) {
      bool IsFound = false;
      string query = $"SELECT * FROM People WHERE PersonID = @PersonID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@PersonID", PersonID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          FirstName = (string)reader["FirstName"];
          SecondName = (string)reader["SecondName"];
          ThirdName = (string)reader["ThirdName"];
          LastName = (string)reader["LastName"];
          NationalNo = (string)reader["NationalNo"];
          Gendor = (byte)reader["Gendor"];
          Email = (string)reader["Email"];
          Phone = (string)reader["Phone"];
          Address = (string)reader["Address"];
          DateOfBirth = (DateTime)reader["DateOfBirth"];
          NationalityCountryPersonID = (int)reader["NationalityCountryID"];

          if(reader["ImagePath"] != DBNull.Value) {
            ImagePath = (string)reader["ImagePath"];
          } else {
            ImagePath = "";
          }

        } else {
          IsFound = false;
        }

        reader.Close();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        IsFound = false;
      } finally {
        connection.Close();
      }

      return IsFound;
    }

    public static bool GetPersonInfoByNationalNo(
        ref int PersonID, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName, string NationalNo,
        ref byte Gendor, ref string Email, ref string Phone, ref string Address,
        ref DateTime DateOfBirth, ref int NationalityCountryPersonID,
        ref string ImagePath) {
      bool IsFound = false;
      string query = $"SELECT * FROM People where NationalNo = @NationalNo";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@NationalNo", NationalNo);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          PersonID = (int)reader["PersonID"];
          FirstName = (string)reader["FirstName"];
          SecondName = (string)reader["SecondName"];
          ThirdName = (string)reader["ThirdName"];
          LastName = (string)reader["LastName"];
          Email = (string)reader["Email"];
          Phone = (string)reader["Phone"];
          Address = (string)reader["Address"];
          DateOfBirth = (DateTime)reader["DateOfBirth"];
          NationalityCountryPersonID = (int)reader["NationalityCountryID"];

          if(reader["ImagePath"] != DBNull.Value) {
            ImagePath = (string)reader["ImagePath"];
          } else {
            ImagePath = "";
          }

        } else {
          IsFound = false;
        }

        reader.Close();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        IsFound = false;
      } finally {
        connection.Close();
      }

      return IsFound;
    }

    public static DataTable GetAllPeople() {
      string query = "SELECT * FROM People";

      DataTable dataTable = new DataTable();

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      try {
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();

        if(reader.HasRows) {
          dataTable.Load(reader);
        }

        reader.Close();
      } catch(Exception ex) {
        Console.WriteLine("Error: " + ex.Message);
      } finally {
        connection.Close();
      }

      return dataTable;
    }

    public static int AddPerson(string FirstName, string SecondName,
                                string ThirdName, string LastName,
                                string NationalNo, byte Gendor, string Email,
                                string Phone, string Address,
                                DateTime DateOfBirth, int NationalityCountryID,
                                string ImagePath) {
      int PersonID = -1;
      string Query = "INSERT INTO People (NationalNo, FirstName, SecondName, " +
                     "ThirdName, LastName, DateOfBirth, Gendor, Address, " +
                     "Phone, Email, NationalityCountryID, ImagePath)" +
                     "VALUES (@NationalNo, @FirstName, @SecondName, " +
                     "@ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, " +
                     "@Phone, @Email, @NationalityCountryID, @ImagePath)" +
                     "SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@NationalNo", NationalNo);
      command.Parameters.AddWithValue("@FirstName", FirstName);
      command.Parameters.AddWithValue("@SecondName", SecondName);
      command.Parameters.AddWithValue("@ThirdName", ThirdName);
      command.Parameters.AddWithValue("@LastName", LastName);
      command.Parameters.AddWithValue("@Email", Email);
      command.Parameters.AddWithValue("@Gendor", Gendor);
      command.Parameters.AddWithValue("@Phone", Phone);
      command.Parameters.AddWithValue("@Address", Address);
      command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
      command.Parameters.AddWithValue("@NationalityCountryID",
                                      NationalityCountryID);

      if(ImagePath != "") {
        command.Parameters.AddWithValue("@ImagePath", ImagePath);
      } else {
        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
      }

      try {
        connection.Open();

        object results = command.ExecuteScalar();

        if(results != null &&
            int.TryParse(results.ToString(), out int insertedPersonID)) {
          PersonID = insertedPersonID;
        }
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return PersonID;
    }

    public static bool UpdatePerson(int PersonID, string FirstName,
                                    string SecondName, string ThirdName,
                                    string LastName, string NationalNo,
                                    byte Gendor, string Email, string Phone,
                                    string Address, DateTime DateOfBirth,
                                    int NationalityCountryID, string ImagePath) {
      int RowsAffected = 0;
      string Query =
          @"UPDATE People SET FirstName = @FirstName, SecondName = " +
          @"@SecondName, ThirdName = @ThirdName, LastName = @LastName, Email = " +
          @"@Email, Phone = @Phone, Address = @Address, DateOfBirth = " +
          @"@DateOfBirth, NationalityCountryID = @NationalityCountryID, " +
          @"ImagePath = @ImagePath, NationalNo = @NationalNo WHERE PersonID = " +
          @"@PersonID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@FirstName", FirstName);
      command.Parameters.AddWithValue("@SecondName", SecondName);
      command.Parameters.AddWithValue("@ThirdName", ThirdName);
      command.Parameters.AddWithValue("@LastName", LastName);
      command.Parameters.AddWithValue("@NationalNo", NationalNo);
      command.Parameters.AddWithValue("@Email", Email);
      command.Parameters.AddWithValue("@Gendor", Gendor);
      command.Parameters.AddWithValue("@Phone", Phone);
      command.Parameters.AddWithValue("@Address", Address);
      command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
      command.Parameters.AddWithValue("@NationalityCountryID",
                                      NationalityCountryID);
      command.Parameters.AddWithValue("@PersonID", PersonID);

      if(ImagePath != "") {
        command.Parameters.AddWithValue("@ImagePath", ImagePath);
      } else {
        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
      }

      try {
        connection.Open();
        RowsAffected = command.ExecuteNonQuery();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        return false;
      } finally {
        connection.Close();
      }

      return (RowsAffected > 0);
    }

    public static bool DeletePerson(int PersonID) {
      int RowsAffected = 0;
      string Query = @"DELETE FROM People WHERE PersonID =@PersonID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@PersonID", PersonID);

      try {
        connection.Open();
        RowsAffected = command.ExecuteNonQuery();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        return false;
      } finally {
        connection.Close();
      }

      return (RowsAffected > 0);
    }

    public static bool DeletePerson(string NationalNo) {
      int RowsAffected = 0;
      string Query = @"DELETE FROM People WHERE NationalNo =@NationalNo";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@NationalNo", NationalNo);

      try {
        connection.Open();
        RowsAffected = command.ExecuteNonQuery();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        return false;
      } finally {
        connection.Close();
      }

      return (RowsAffected > 0);
    }

    public static bool IsPersonExist(int PersonID) {
      bool IsFound = false;
      string query = $"SELECT IsFound = 1 FROM People where PersonID = @PersonID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@PersonID", PersonID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        IsFound = reader.HasRows;
        reader.Close();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        IsFound = false;
      } finally {
        connection.Close();
      }

      return IsFound;
    }

    public static bool IsPersonExist(string NationalNo) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM People where NationalNo = @NationalNo";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@NationalNo", NationalNo);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        IsFound = reader.HasRows;
        reader.Close();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        IsFound = false;
      } finally {
        connection.Close();
      }

      return IsFound;
    }
  }
}
