using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsLicenseDataAccessLayer {
    public static bool
    GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID) {
      bool IsFound = false;
      string query = $"SELECT * FROM Licenses where LicenseID = @LicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LicenseID", LicenseID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          ApplicationID = (int)reader["ApplicationID"];
          DriverID = (int)reader["DriverID"];
          LicenseClass = (int)reader["LicenseClass"];
          IssueDate = (DateTime)reader["IssueDate"];
          ExpirationDate = (DateTime)reader["ExpirationDate"];

          if(reader["Notes"] != DBNull.Value) {
            Notes = (string)reader["Notes"];
          } else {
            Notes = "";
          }

          PaidFees = (decimal)reader["PaidFees"];
          IsActive = (bool)reader["IsActive"];
          IssueReason = (byte)reader["IssueReason"];
          CreatedByUserID = (int)reader["CreatedByUserID"];

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

    public static bool
    GetLicenseInfoByPersonID(ref int LicenseID, ref int ApplicationID, int DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID) {
      bool IsFound = false;
      string query = $"SELECT * FROM Licenses where DriverID = @DriverID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@DriverID", DriverID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          ApplicationID = (int)reader["ApplicationID"];
          LicenseID = (int)reader["LicenseID"];
          LicenseClass = (int)reader["LicenseClass"];
          IssueDate = (DateTime)reader["IssueDate"];
          ExpirationDate = (DateTime)reader["ExpirationDate"];

          if(reader["Notes"] != DBNull.Value) {
            Notes = (string)reader["Notes"];
          } else {
            Notes = "";
          }

          PaidFees = (decimal)reader["PaidFees"];
          IsActive = (bool)reader["IsActive"];
          IssueReason = (byte)reader["IssueReason"];
          CreatedByUserID = (int)reader["CreatedByUserID"];

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

    public static bool
    GetLicenseInfoByApplicationID(ref int LicenseID, int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID) {
      bool IsFound = false;
      string query = $"SELECT * FROM Licenses where ApplicationID = @ApplicationID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          DriverID = (int)reader["DriverID"];
          LicenseID = (int)reader["LicenseID"];
          LicenseClass = (int)reader["LicenseClass"];
          IssueDate = (DateTime)reader["IssueDate"];
          ExpirationDate = (DateTime)reader["ExpirationDate"];

          if(reader["Notes"] != DBNull.Value) {
            Notes = (string)reader["Notes"];
          } else {
            Notes = "";
          }

          PaidFees = (decimal)reader["PaidFees"];
          IsActive = (bool)reader["IsActive"];
          IssueReason = (byte)reader["IssueReason"];
          CreatedByUserID = (int)reader["CreatedByUserID"];

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


    public static DataTable GetAllLicenses() {
      string query = "SELECT * FROM Licenses";

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

    public static int AddLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID) {
      int LicenseID = -1;
      string Query =
          $"INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID) VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
      command.Parameters.AddWithValue("@DriverID", DriverID);
      command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
      command.Parameters.AddWithValue("@IssueDate", IssueDate);
      command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
      command.Parameters.AddWithValue("@Notes", Notes);
      command.Parameters.AddWithValue("@PaidFees", PaidFees);
      command.Parameters.AddWithValue("@IsActive", IsActive);
      command.Parameters.AddWithValue("@IssueReason", IssueReason);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

      try {
        connection.Open();

        object results = command.ExecuteScalar();

        if(results != null &&
            int.TryParse(results.ToString(), out int insertedLicenseID)) {
          LicenseID = insertedLicenseID;
        }
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return DriverID;
    }

    public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID) {
      int RowsAffected = 0;
      string Query =
          $"UPDATE Licenses SET ApplicationID = @ApplicationID, DriverID = @DriverID, LicenseClass = @LicenseClass, IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, Notes = @Notes, PaidFees = @PaidFees, IsActive = @IsActive, IssueReason = @IssueReason, CreatedByUserID = @CreatedByUserID WHERE LicenseID = @LicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@LicenseID", LicenseID);
      command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
      command.Parameters.AddWithValue("@DriverID", DriverID);
      command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
      command.Parameters.AddWithValue("@IssueDate", IssueDate);
      command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
      command.Parameters.AddWithValue("@Notes", Notes);
      command.Parameters.AddWithValue("@PaidFees", PaidFees);
      command.Parameters.AddWithValue("@IsActive", IsActive);
      command.Parameters.AddWithValue("@IssueReason", IssueReason);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

    public static bool DeleteLicense(int LicenseID) {
      int RowsAffected = 0;
      string Query = $"DELETE FROM Licenses WHERE LicenseID = @LicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

    public static bool DeleteLicenseByDriverID(int DriverID) {
      int RowsAffected = 0;
      string Query = $"DELETE FROM Licenses WHERE DriverID = @DriverID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@DriverID", DriverID);

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

    public static bool IsLicenseExist(int LicenseID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM Licenses where LicenseID = @LicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

    public static bool IsLicenseExistByDriverID(int DriverID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM Licenses where DriverID = @DriverID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@DriverID", DriverID);

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
