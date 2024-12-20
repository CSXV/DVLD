using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsInternationalLicensesDataAccessLayer {
    public static bool
    GetIntLicenseInfoByID(int InternationalLicenseID, ref int ApplicationID,
                          ref int DriverID, ref int IssuedUsingLocalLicenseID,
                          ref DateTime IssueDate, ref DateTime ExpirationDate,
                          ref bool IsActive, ref int CreatedByUserID) {
      bool IsFound = false;
      string query =
          $"SELECT * FROM InternationalLicenses where InternationalLicenseID= @InternationalLicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@InternationalLicenseID",
                                      InternationalLicenseID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          ApplicationID = (int)reader["ApplicationID"];
          DriverID = (int)reader["DriverID"];
          IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID "];
          IssueDate = (DateTime)reader["IssueDate"];
          ExpirationDate = (DateTime)reader["ExpirationDate"];
          IsActive = (bool)reader["IsActive"];
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

    public static bool GetIntLicenseInfoByDriverID(
        ref int InternationalLicenseID, ref int ApplicationID, int DriverID,
        ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate,
        ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID) {
      bool IsFound = false;
      string query =
          $"SELECT * FROM InternationalLicenses where DriverID= @DriverID";

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
          InternationalLicenseID = (int)reader["InternationalLicenseID "];
          IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID "];
          IssueDate = (DateTime)reader["IssueDate"];
          ExpirationDate = (DateTime)reader["ExpirationDate"];
          IsActive = (bool)reader["IsActive"];
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

    public static DataTable GetAllIntLicenses() {
      string query = "SELECT * FROM InternationalLicenses";

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

    public static int AddLicense(int ApplicationID, int DriverID,
                                 int IssuedUsingLocalLicenseID,
                                 DateTime IssueDate, DateTime ExpirationDate,
                                 bool IsActive, int CreatedByUserID) {
      int LicenseID = -1;
      string Query =
          $"INSERT INTO InternationalLicenses (ApplicationID ,DriverID ,IssuedUsingLocalLicenseID ,IssueDate ,ExpirationDate ,IsActive ,CreatedByUserID) VALUES (@ApplicationID ,@DriverID ,@IssuedUsingLocalLicenseID ,@IssueDate ,@ExpirationDate ,@IsActive ,@CreatedByUserID) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
      command.Parameters.AddWithValue("@DriverID", DriverID);
      command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID",
                                      IssuedUsingLocalLicenseID);
      command.Parameters.AddWithValue("@IssueDate", IssueDate);
      command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
      command.Parameters.AddWithValue("@IsActive", IsActive);
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

    public static bool UpdateLicense(int InternationalLicenseID,
                                     int ApplicationID, int DriverID,
                                     int IssuedUsingLocalLicenseID,
                                     DateTime IssueDate, DateTime ExpirationDate,
                                     bool IsActive, int CreatedByUserID) {
      int RowsAffected = 0;
      string Query =
          $"UPDATE InternationalLicenses SET ApplicationID = @ApplicationID ,DriverID = @DriverID ,IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID ,IssueDate = @IssueDate ,ExpirationDate = @ExpirationDate ,IsActive = @IsActive ,CreatedByUserID = @CreatedByUserID WHERE InternationalLicenseID = @InternationalLicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@InternationalLicenseID",
                                      InternationalLicenseID);
      command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
      command.Parameters.AddWithValue("@DriverID", DriverID);
      command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID",
                                      IssuedUsingLocalLicenseID);
      command.Parameters.AddWithValue("@IssueDate", IssueDate);
      command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
      command.Parameters.AddWithValue("@IsActive", IsActive);
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

    public static bool DeleteLicense(int InternationalLicenseID) {
      int RowsAffected = 0;
      string Query =
          $"DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@InternationalLicenseID",
                                      InternationalLicenseID);

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
      string Query =
          $"DELETE FROM InternationalLicenses WHERE DriverID = @DriverID";

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

    public static bool IsLicenseExist(int InternationalLicenseID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM InternationalLicenses where InternationalLicenseID = @InternationalLicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@InternationalLicenseID",
                                      InternationalLicenseID);

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
          $"SELECT IsFound = 1 FROM InternationalLicenses where DriverID = @DriverID";

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

    public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID,
                                          int TestTypeID) {

      bool IsFound = false;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);

      string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                                      LocalDrivingLicenseApplicationID);
      command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

      try {
        connection.Open();

        object result = command.ExecuteScalar();

        if(result != null) {
          IsFound = true;
        }
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);

      } finally {
        connection.Close();
      }

      return IsFound;
    }
  }
}
