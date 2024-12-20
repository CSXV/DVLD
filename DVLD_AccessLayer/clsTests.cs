using DVLD_AccessLayerSettings;
using System;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsTestsDataAccessLayer {
    public static int AddTest(int TestAppointment, bool TestResults, string Notes, int CreatedByUserID) {
      int UserID = -1;
      string Query = "INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@TestAppointmentID", TestAppointment);
      command.Parameters.AddWithValue("@TestResult", TestResults);
      command.Parameters.AddWithValue("@Notes", Notes);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

    public static bool UpdateTest(int TestID, int TestAppointment,
                                  bool TestResults, string Notes,
                                  int CreatedByUserID) {
      int RowsAffected = 0;
      string Query =
          $"UPDATE Tests SET TestAppointment = @TestAppointmentID, TestResults = @TestResults, Notes = @Notes, CreatedByUserID = @CreatedByUserID WHERE TestID = @TestID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@TestID", TestID);
      command.Parameters.AddWithValue("@TestAppointmentID", TestAppointment);
      command.Parameters.AddWithValue("@TestResults", TestResults);
      command.Parameters.AddWithValue("@Notes", Notes);
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

    public static bool GetTestInfoByID(int TestID, ref int TestAppointmentID, ref bool TestResults, ref string Notes, ref int CreatedByUserID) {
      bool IsFound = false;
      string query = $"SELECT * FROM Tests where TestID = @TestID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@TestID", TestID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          TestAppointmentID = (int)reader["TestAppointmentID"];
          TestResults = (bool)reader["TestResults"];
          Notes = (string)reader["Notes"];
          CreatedByUserID = (int)reader["ApplicationStatus"];

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
  }
}
