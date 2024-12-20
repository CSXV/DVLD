using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsTestTypeDataAccessLayer {
    public static bool GetTestTypeInfoByID(int TestTypeID, ref string Title, ref string Description, ref decimal Fees) {
      bool IsFound = false;
      string query = $"SELECT * FROM TestTypes where TestTypeID = @TestTypeID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          Title = (string)reader["TestTypeTitle"];
          Description = (string)reader["TestTypeDescription"];
          Fees = (decimal)reader["TestTypeFees"];
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

    public static DataTable GetAllTestTypes() {
      string query = "SELECT * FROM TestTypes";

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

    public static bool UpdateTestType(int TestTypeID, string Title,
                                      string Description, decimal Fees) {
      int RowsAffected = 0;
      string Query =
          @"UPDATE TestTypes SET TestTypeTitle = @Title, TestTypeDescription = " +
          @"@Description, TestTypeFees = @Fees WHERE TestTypeID = @TestTypeID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
      command.Parameters.AddWithValue("@Title", Title);
      command.Parameters.AddWithValue("@Description", Description);
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

    public static bool IsTestTypeExist(int TestTypeID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM TestTypes where TestTypeID = @TestTypeID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
