using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsDetainDataAccessLayer {
    public static bool
    GetDetainInfoByID(int DetainID, ref int LicenseID,
      ref DateTime DetainTime, ref decimal FineFees,
      ref int CreatedByUserID, ref bool IsReleased,
      ref DateTime ReleaseDate, ref int ReleasedByUserID,
      ref int ReleaseApplicationID) {
      bool IsFound = false;
      string query =
          $"SELECT * FROM DetainedLicenses where DetainID = @DetainID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@DetainID", DetainID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          LicenseID = (int)reader["LicenseID"];
          DetainTime = (DateTime)reader["DetainDate"];
          FineFees = (decimal)reader["FineFees"];
          CreatedByUserID = (int)reader["CreatedByUserID"];
          IsReleased = (bool)reader["IsReleased"];
          ReleaseDate = (DateTime)reader["ReleaseDate"];
          ReleasedByUserID = (int)reader["ReleasedByUserID"];
          ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

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
    GetDetainInfoByLicenseID(ref int DetainID, int LicenseID,
      ref DateTime DetainTime, ref decimal FineFees,
      ref int CreatedByUserID, ref bool IsReleased,
      ref DateTime ReleaseDate, ref int ReleasedByUserID,
      ref int ReleaseApplicationID) {
      bool IsFound = false;
      string query =
          $"SELECT * FROM DetainedLicenses where LicenseID = @LicenseID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LicenseID", LicenseID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          DetainID = (int)reader["DetainID"];
          DetainTime = (DateTime)reader["DetainDate"];
          FineFees = (decimal)reader["FineFees"];
          CreatedByUserID = (int)reader["CreatedByUserID"];
          IsReleased = (bool)reader["IsReleased"];

          if(reader["ReleaseDate"] != DBNull.Value) {
            ReleaseDate = (DateTime)reader["ReleaseDate"];
          } else {
            ReleaseDate = DateTime.Now;
          }

          if(reader["ReleasedByUserID"] != DBNull.Value) {
            ReleasedByUserID = (int)reader["ReleasedByUserID"];
          } else {
            ReleasedByUserID = -1;
          }

          if(reader["ReleaseApplicationID"] != DBNull.Value) {
            ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
          } else {
            ReleaseApplicationID = -1;
          }

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

    public static int AddDetain1(int LicenseID, DateTime DetainTime,
      decimal FineFees, int CreatedByUserID, bool IsReleased,
      DateTime ReleaseDate, int? ReleasedByUserID,
      int ReleaseApplicationID) {
      int AppID = -1;
      string Query =
      $"INSERT INTO DetainedLicenses (LicenseID ,DetainDate ,FineFees ,CreatedByUserID ,IsReleased ,ReleaseDate ,ReleasedByUserID ,ReleaseApplicationID) VALUES (@LicenseID ,@DetainDate ,@FineFees ,@CreatedByUserID ,@IsReleased ,@ReleaseDate ,@ReleasedByUserID ,@ReleaseApplicationID) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@LicenseID", LicenseID);
      command.Parameters.AddWithValue("@DetainDate", DetainTime);
      command.Parameters.AddWithValue("@FineFees", FineFees);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
      command.Parameters.AddWithValue("@IsReleased", IsReleased);
      command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
      command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
      command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

    public static int AddDetain(int LicenseID, DateTime DetainTime,
      decimal FineFees, int CreatedByUserID) {
      int AppID = -1;
      string Query =
      $"INSERT INTO DetainedLicenses (LicenseID ,DetainDate ,FineFees ,CreatedByUserID) VALUES (@LicenseID ,@DetainDate ,@FineFees ,@CreatedByUserID) SELECT SCOPE_IDENTITY();";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@LicenseID", LicenseID);
      command.Parameters.AddWithValue("@DetainDate", DetainTime);
      command.Parameters.AddWithValue("@FineFees", FineFees);
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


    public static bool UpdateDetain(int DetainID, int LicenseID, DateTime DetainTime, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int? ReleasedByUserID, int ReleaseApplicationID) {
      int RowsAffected = 0;
      string Query =
      $"UPDATE DetainedLicenses SET LicenseID = @LicenseID, DetainDate = @DetainDate, FineFees = @FineFees, CreatedByUserID = @CreatedByUserID, IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID WHERE DetainID = @DetainID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@DetainID", DetainID);
      command.Parameters.AddWithValue("@LicenseID", LicenseID);
      command.Parameters.AddWithValue("@DetainDate", DetainTime);
      command.Parameters.AddWithValue("@FineFees", FineFees);
      command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
      command.Parameters.AddWithValue("@IsReleased", IsReleased);
      command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
      command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
      command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

    public static bool DeleteDetain(int DetainID) {
      int RowsAffected = 0;
      string Query = @"DELETE FROM DetainedLicenses WHERE DetainID = @DetainID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@DetainID", DetainID);

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

    public static bool IsDetainExist(int DetainID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM DetainedLicenses where DetainID = @DetainID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@DetainID", DetainID);

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

    public static bool IsDetainExistByLicenseID(int LicenseID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM DetainedLicenses where LicenseID = @LicenseID";

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

    public static bool IsActiveDetainExistByLicenseID(int LicenseID) {
      bool IsFound = false;
      string query =
          $"SELECT IsFound = 1 FROM DetainedLicenses where LicenseID = @LicenseID AND IsReleased = 0";

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


    public static DataTable GetAllDetains() {
      string query = "SELECT * FROM DetainedLicenses";

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
