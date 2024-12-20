using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsLocalDrivingLicenseDataAccessLayer {
    public static bool GetLDLInfoByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID) {
      bool IsFound = false;
      string query =
          $"SELECT * FROM LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                                      LocalDrivingLicenseApplicationID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          ApplicationID = (int)reader["ApplicationID"];
          LicenseClassID = (int)reader["LicenseClassID"];

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

    public static int AddLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID) {
      int LLAID = -1;
      string Query =
          $"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID) SELECT SCOPE_IDENTITY();";
      string CheckSQL =
          $"SELECT COUNT(*) FROM Applications WHERE ApplicationID = @ApplicationID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);

      SqlCommand command = new SqlCommand(Query, connection);
      SqlCommand CheckCommand = new SqlCommand(CheckSQL, connection);

      command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
      command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
      CheckCommand.Parameters.AddWithValue(@"ApplicationID", ApplicationID);

      try {
        connection.Open();

        int count = (int)CheckCommand.ExecuteScalar();
        if(count == 0) {
          return LLAID;
        }

        object results = command.ExecuteScalar();

        if(results != null &&
            int.TryParse(results.ToString(), out int insertedID)) {
          LLAID = insertedID;
        }

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return LLAID;
    }

    public static DataTable GetAllLocalDrivingLicensesApplication() {
      string query =
          $"SELECT       " + "dbo.LocalDrivingLicenseApplications." +
          "LocalDrivingLicenseApplicationID, dbo.LicenseClasses.ClassName, " +
          "dbo.People.NationalNo, dbo.People.FirstName + ' ' + " +
          "dbo.People.SecondName + ' ' + ISNULL(dbo.People.ThirdName, '') + ' " +
          "' + dbo.People.LastName AS FullName, " +
          "dbo.Applications.ApplicationDate, (SELECT       " +
          "COUNT(dbo.TestAppointments.TestTypeID) AS PassedTestCount FROM      " +
          "       dbo.Tests INNER JOIN dbo.TestAppointments ON " +
          "dbo.Tests.TestAppointmentID = " +
          "dbo.TestAppointments.TestAppointmentID WHERE         " +
          "(dbo.TestAppointments.LocalDrivingLicenseApplicationID = " +
          "dbo.LocalDrivingLicenseApplications." +
          "LocalDrivingLicenseApplicationID) AND (dbo.Tests.TestResult = 1)) " +
          "AS PassedTestCount, CASE WHEN Applications.ApplicationStatus = 1 " +
          "THEN 'New' WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled' " +
          "WHEN Applications.ApplicationStatus = 3 THEN 'Completed' END AS " +
          "Status FROM            dbo.LocalDrivingLicenseApplications INNER " +
          "JOIN dbo.Applications ON " +
          "dbo.LocalDrivingLicenseApplications.ApplicationID = " +
          "dbo.Applications.ApplicationID INNER JOIN dbo.LicenseClasses ON " +
          "dbo.LocalDrivingLicenseApplications.LicenseClassID = " +
          "dbo.LicenseClasses.LicenseClassID INNER JOIN dbo.People ON " +
          "dbo.Applications.ApplicantPersonID = dbo.People.PersonID";

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

    public static bool IsLocalDrivingLicenseExist(int AppID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM LocalDrivingLicenseApplication where LocalDrivingLicenseApplicationID = @AppID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", AppID);

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

    public static bool DeleteLocalLicenseApplication(int AppID) {
      int RowsAffected = 0;
      string Query =
          $"DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID =@AppID";

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

    public static bool UpdateLocalLicenseApplication(int LDLAID, int AppID, int LicenseClassID) {
      int RowsAffected = 0;
      string Query =
          $"UPDATE LocalDrivingLicenseApplication SET ApplicationID = @AppID, LicenseClassID = @LicenseClassID WHERE LocalDrivingLicenseApplicationID = @LDLAID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@LDLAID", LDLAID);
      command.Parameters.AddWithValue("@AppID", AppID);
      command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

    public static int FindAppID(int LocalDrivingLicenseApplicationID) {
      int AppID = -1;
      string query =
          $"SELECT * FROM LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                                      LocalDrivingLicenseApplicationID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          AppID = (int)reader["ApplicationID"];
        } else {
          AppID = -1;
        }

        reader.Close();

      } catch(Exception ex) {
        clsEventLogger.LogError(ex);
        AppID = -1;
      } finally {
        connection.Close();
      }

      return AppID;
    }

    public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID) {

      byte TotalTrialsPerTest = 0;

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);

      string query = @" SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                       ";

      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                                      LocalDrivingLicenseApplicationID);
      command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

      try {
        connection.Open();

        object result = command.ExecuteScalar();

        if(result != null && byte.TryParse(result.ToString(), out byte Trials)) {
          TotalTrialsPerTest = Trials;
        }
      } catch(Exception ex) {
        clsEventLogger.LogError(ex);

      } finally {
        connection.Close();
      }

      return TotalTrialsPerTest;
    }

    public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID) {
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
