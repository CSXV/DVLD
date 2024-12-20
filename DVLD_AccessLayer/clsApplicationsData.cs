using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsApplicationsDataAccessLayer {
    public static bool
    GetApplicationInfoByID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref byte ApplicationStatus, ref DateTime LastStautsDate, ref decimal PaidFees, ref int CreatedByUserID) {
      bool IsFound = false;
      string query =
          $"SELECT * FROM Applications where ApplicationID = @ApplicationID";

      SqlConnection connection =
         new SqlConnection(clsDataAccessSettings.ConnectionString);
      //SqlConnection connection =
      //   new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          ApplicantPersonID = (int)reader["ApplicantPersonID"];
          ApplicationDate = (DateTime)reader["ApplicationDate"];
          ApplicationTypeID = (int)reader["ApplicationTypeID"];
          ApplicationStatus = (byte)reader["ApplicationStatus"];
          LastStautsDate = (DateTime)reader["LastStatusDate"];
          PaidFees = (decimal)reader["PaidFees"];
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

    public static int AddApplication(int ApplicantPersonID,
                                     DateTime ApplicationDate,
                                     int ApplicationTypeID,
                                     byte ApplicationStatus,
                                     DateTime LastStautsDate,
                                     decimal PaidFees,
                                     int CreatedByUserID) {
      int AppID = -1;
      string Query =
          @"INSERT INTO Applications (ApplicantPersonID ,ApplicationDate " +
          ",ApplicationTypeID ,ApplicationStatus ,LastStatusDate ,PaidFees " +
          ",CreatedByUserID) VALUES (@ApplicantPersonID, @ApplicationDate, " +
          "@ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, " +
          "@CreatedByUserID) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
      command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
      command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
      command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
      command.Parameters.AddWithValue("@LastStatusDate", LastStautsDate);
      command.Parameters.AddWithValue("@PaidFees", PaidFees);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

      try {
        connection.Open();

        object results = command.ExecuteScalar();

        if(results != null &&
            int.TryParse(results.ToString(), out int insertedPersonID)) {
          AppID = insertedPersonID;
        }
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return AppID;
    }

    public static bool UpdateApplication(int ApplicationID,
                                     int ApplicantPersonID,
                                  DateTime ApplicationDate,
                                     int ApplicationTypeID,
                                    byte ApplicationStatus,
                                   DateTime LastStatusDate,
                                          decimal PaidFees,
                                       int CreatedByUserID) {
      int RowsAffected = 0;
      string Query =
          @"UPDATE Applications SET ApplicantPersonID = @ApplicantPersonID " +
          ",ApplicationDate = @ApplicationDate ,ApplicationTypeID = " +
          "@ApplicationTypeID ,ApplicationStatus = @ApplicationStatus " +
          ",LastStatusDate = @LastStatusDate ,PaidFees = @PaidFees " +
          ",CreatedByUserID = @CreatedByUserID WHERE ApplicationID = " +
          "@ApplicationID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
      command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
      command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
      command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
      command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
      command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
      command.Parameters.AddWithValue("@PaidFees", PaidFees);
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

    public static bool CancelApplication(int AppID) {
      int RowsAffected = 0;
      string Query = @"UPDATE Applications SET ApplicationStatus = 2 WHERE " +
                     @"ApplicationID = @ApplicationID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@ApplicationID", AppID);

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

    public static bool DeleteApplication(int AppID) {
      int RowsAffected = 0;
      string Query = @"DELETE FROM Applications WHERE ApplicationID = @AppID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@AppID", AppID);

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

    public static bool IsApplicationExist(int AppID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM Applications where ApplicationID = @AppID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@ApplicationID", AppID);

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

    public static bool IsApplicationExistByPersonAndType(
                                    int ApplicantPersonID,
                                    int ApplicationTypeID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM Applications where ApplicantPersonID = @ApplicantPersonID AND ApplicationTypeID = @ApplicationTypeID AND ApplicationStatus = 1";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
      command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

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

    public static DataTable GetAllApplications() {
      string query = "SELECT * FROM Application";

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
