using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DVLD_AccessLayerSettings;
using System.Data;

namespace DVLD_AccessLayer
{
  public class clsAppointmentDataAccessLayer
  {
    public static DataTable GetAllAppointments()
    {
      string query = "SELECT * FROM TestAppointments";

      DataTable dataTable = new DataTable();

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      try
      {
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
          dataTable.Load(reader);
        }

        reader.Close();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error: " + ex.Message);
      }
      finally
      {
        connection.Close();
      }

      return dataTable;
    }

    public static int AddAppointment(int TestAppointmentID, int TestTypeID,
                                     int LocalDrivingLicenseApplicationID,
                                     DateTime AppointmentDate, decimal PaidFees,
                                     int CreatedByUserID, byte IsLocked)
    {
      int AppID = -1;
      string Query =
          @"INSERT INTO [dbo].[TestAppointments] ([TestTypeID] " +
          @",[LocalDrivingLicenseApplicationID] ,[AppointmentDate] ,[PaidFees] " +
          @",[CreatedByUserID] ,[IsLocked]) VALUES (TestTypeID, " +
          @"LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, " +
          @"CreatedByUserID, IsLocked) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
      command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                                      LocalDrivingLicenseApplicationID);
      command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
      command.Parameters.AddWithValue("@PaidFees", PaidFees);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
      command.Parameters.AddWithValue("@IsLocked", IsLocked);

      try
      {
        connection.Open();

        object results = command.ExecuteScalar();

        if (results != null &&
            int.TryParse(results.ToString(), out int insertedPersonID))
        {
          AppID = insertedPersonID;
        }
      }
      catch (Exception ex)
      {
        // Console.WriteLine("Error: " + ex.Message);
      }
      finally
      {
        connection.Close();
      }

      return AppID;
    }
  }
}
