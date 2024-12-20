using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsUserDataAccessLayer {
    public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName, ref bool IsActive, ref string Password) {
      bool IsFound = false;
      string query = $"SELECT * FROM Users where UserID = @UserID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@UserID", UserID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          PersonID = (int)reader["PersonID"];
          UserName = (string)reader["UserName"];
          Password = (string)reader["Password"];
          IsActive = (bool)reader["IsActive"];
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

    public static bool GetUserInfoByName(ref int UserID, ref int PersonID, string UserName, ref bool IsActive, ref string Password) {
      bool IsFound = false;
      string query = $"SELECT * FROM Users where UserName = @UserName";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@UserName", UserName);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          PersonID = (int)reader["PersonID"];
          UserID = (int)reader["UserID"];
          Password = (string)reader["Password"];
          IsActive = (bool)reader["IsActive"];
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

    public static DataTable GetAllUsers() {
      string query = "SELECT * FROM Users";

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

    public static int AddUser(int PersonID, string UserName, bool IsActive, string Password) {
      int UserID = -1;
      string Query = "INSERT INTO Users (PersonID, UserName, IsActive, Password)" +
          "VALUES (@PersonID, @UserName, @IsActive, @Password)" +
          "SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@PersonID", PersonID);
      command.Parameters.AddWithValue("@UserName", UserName);
      command.Parameters.AddWithValue("@IsActive", IsActive);
      command.Parameters.AddWithValue("@Password", Password);

      try {
        connection.Open();

        object results = command.ExecuteScalar();

        if(results != null &&
            int.TryParse(results.ToString(), out int insertedUserID)) {
          UserID = insertedUserID;
        }
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return UserID;
    }

    public static bool UpdateUser(int UserID, int PersonID, string UserName, bool IsActive, string Password) {
      int RowsAffected = 0;
      string Query = @"UPDATE Users SET PersonID = @PersonID, UserName = @UserName, IsActive = @IsActive, Password = @Password WHERE UserID = @UserID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@UserID", UserID);
      command.Parameters.AddWithValue("@PersonID", PersonID);
      command.Parameters.AddWithValue("@UserName", UserName);
      command.Parameters.AddWithValue("@IsActive", IsActive);
      command.Parameters.AddWithValue("@Password", Password);

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

    public static bool DeleteUser(int UserID) {
      int RowsAffected = 0;
      string Query = @"DELETE FROM Users WHERE UserID =@UserID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@UserID", UserID);

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

    public static bool DeleteUser(string UserName) {
      int RowsAffected = 0;
      string Query = @"DELETE FROM Users WHERE UserName =@UserName";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@UserName", UserName);

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

    public static bool IsUserExist(int UserID) {
      bool IsFound = false;
      string query = $"SELECT IsFound = 1 FROM Users where UserID = @UserID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@UserID", UserID);

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

    public static bool IsUserExist(string UserName) {
      bool IsFound = false;
      string query = $"SELECT IsFound = 1 FROM Users where UserName = @UserName";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@UserName", UserName);

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
