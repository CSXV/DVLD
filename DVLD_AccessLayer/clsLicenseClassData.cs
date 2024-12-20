﻿using DVLD_AccessLayerSettings;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_AccessLayer {
  public class clsLicenseClassDataAccessLayer {
    public static bool GetLicenseClassInfoByID(
      int LicenseClassID, ref string ClassName,
      ref string ClassDescription,
      ref byte MinimumAllowedAge,
      ref byte DefaultValidityLength,
      ref decimal ClassFees) {
      bool IsFound = false;
      string query = $"SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

      SqlConnection connection =
          new SqlConnection(clsDataAccessSettings.ConnectionString);
      SqlCommand command = new SqlCommand(query, connection);

      command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

      try {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read()) {
          IsFound = true;

          ClassName = (string)reader["ClassName"];
          ClassDescription = (string)reader["ClassDescription"];
          MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
          DefaultValidityLength = (byte)reader["DefaultValidityLength"];
          ClassFees = (decimal)reader["ClassFees"];
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

    public static DataTable GetAllLicensesTable() {
      string query = "SELECT * FROM LicenseClasses";

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
        clsEventLogger.LogError(ex);
      } finally {
        connection.Close();
      }

      return dataTable;
    }
  }
}
