using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsTestAppointmentDataAccessLayer {
    public static DataTable GetAllTestAppointments() {
      string query = "SELECT * FROM TestAppointments";

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

    public static int AddTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked) {
      int AppID = -1;
      string Query =
          $"INSERT INTO TestAppointments (TestTypeID ,LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked) VALUES (@TestTypeID, @LDLAID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
      command.Parameters.AddWithValue("@LDLAID",
                                      LocalDrivingLicenseApplicationID);
      command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
      command.Parameters.AddWithValue("@PaidFees", PaidFees);
      command.Parameters.AddWithValue("@IsLocked", IsLocked);

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

    public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked) {
      int RowsAffected = 0;
      string Query =
          $"UPDATE TestAppointments SET AppointmentDate = @AppointmentDate, PaidFees = @PaidFees, IsLocked = @IsLocked WHERE TestAppointmentID = @TestAppointmentID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
      //command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
      //command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
      command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
      //command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
      command.Parameters.AddWithValue("@PaidFees", PaidFees);
      command.Parameters.AddWithValue("@IsLocked", IsLocked);

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

    public static bool
    GetTestAppointmentsByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked) {
      bool IsFound = false;
      string query =
          $"SELECT * FROM TestAppointments where TestAppointmentID = @TestAppointmentID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          TestAppointmentID = (int)reader["TestAppointmentID"];
          TestTypeID = (int)reader["TestTypeID"];
          LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
          AppointmentDate = (DateTime)reader["AppointmentDate"];
          CreatedByUserID = (int)reader["CreatedByUserID"];
          PaidFees = (decimal)reader["PaidFees"];
          IsLocked = (bool)reader["IsLocked"];

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
