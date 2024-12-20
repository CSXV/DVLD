
using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsDriverDataAccessLayer {
    public static bool GetDriverInfoByID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate) {
      bool IsFound = false;
      string query = $"SELECT * FROM Drivers where DriverID = @DriverID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@DriverID", DriverID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          PersonID = (int)reader["PersonID"];
          CreatedDate = (DateTime)reader["CreatedDate"];
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

    public static bool GetDriverInfoByPersonID(ref int DriverID, int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate) {
      bool IsFound = false;
      string query = $"SELECT * FROM Drivers where PersonID = @PersonID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@PersonID", PersonID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          DriverID = (int)reader["DriverID"];
          CreatedDate = (DateTime)reader["CreatedDate"];
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

    public static DataTable GetAllDrivers() {
      string query = "SELECT * FROM Drivers";

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

    public static int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate) {
      int DriverID = -1;
      string Query =
          @"INSERT INTO Drivers (PersonID ,CreatedByUserID ,CreatedDate) " +
          @"VALUES " +
          "(@PersonID, @CreatedByUserID, @CreatedDate) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@PersonID", PersonID);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
      command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

      try {
        connection.Open();

        object results = command.ExecuteScalar();

        if(results != null &&
            int.TryParse(results.ToString(), out int insertedDriverID)) {
          DriverID = insertedDriverID;
        }
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return DriverID;
    }

    public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate) {
      int RowsAffected = 0;
      string Query = @"UPDATE Drivers SET PersonID = @PersonID, " +
                     @"CreatedByUserID = @CreatedByUserID, CreatedDate = " +
                     @"@CreatedDate WHERE DriverID = @DriverID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@DriverID", DriverID);
      command.Parameters.AddWithValue("@PersonID", PersonID);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
      command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

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

    public static bool DeleteDriver(int DriverID) {
      int RowsAffected = 0;
      string Query = @"DELETE FROM Users WHERE DriverID = @DriverID";

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

    public static bool DeleteDriverByPersonID(int PersonID) {
      int RowsAffected = 0;
      string Query = @"DELETE FROM Drivers WHERE PersonID = @PersonID";

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

    public static bool IsDriverExist(int DriverID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM Drivers where DriverID = @DriverID";

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

    public static bool IsDriverExistByPersonID(int PersonID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM Drivers where PersonID = @PersonID";

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

    public static DataTable GetAllDriversTable() {
      string query =
          "SELECT       dbo.Drivers.DriverID, dbo.Drivers.PersonID, " +
          "dbo.People.NationalNo, dbo.People.FirstName + ' ' + " +
          "dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' " +
          "' + dbo.People.LastName AS FullName, dbo.Drivers.CreatedDate, " +
          "(SELECT       COUNT(LicenseID) AS NumberOfActiveLicenses FROM       " +
          "      dbo.Licenses WHERE         (IsActive = 1) AND (DriverID = " +
          "dbo.Drivers.DriverID)) AS NumberOfActiveLicenses FROM            " +
          "dbo.Drivers INNER JOIN dbo.People ON dbo.Drivers.PersonID = " +
          "dbo.People.PersonID";

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
  }
}
