using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsApplicationTypeDataAccessLayer {
    public static bool GetAppTypeInfoByID(int AppTypeID, ref string Title,
                                          ref decimal Fees) {
      bool IsFound = false;
      string query =
          $"SELECT * FROM ApplicationTypes where ApplicationTypeID = @AppTypeID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@AppTypeID", AppTypeID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          Title = (string)reader["ApplicationTypeTitle"];
          Fees = (decimal)reader["ApplicationFees"];
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

    public static DataTable GetAllApplicationTypes() {
      string query = "SELECT * FROM ApplicationTypes";

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

    public static bool UpdateApplicationType(int AppTypeID, string Title,
                                             decimal Fees) {
      int RowsAffected = 0;
      string Query =
          @"UPDATE ApplicationTypes SET ApplicationTypeTitle = @Title, " +
          @"ApplicationFees = @Fees WHERE ApplicationTypeID = @AppTypeID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@AppTypeID", AppTypeID);
      command.Parameters.AddWithValue("@Title", Title);
      command.Parameters.AddWithValue("@Fees", Fees);

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

    public static bool IsAppTypeExist(int AppTypeID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM ApplicationTypes where ApplicationTypeID = @AppTypeID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@ApplicationTypeID", AppTypeID);

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
