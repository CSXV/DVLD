using System;
using System.Security.Cryptography;
using System.Text;

namespace DVLD_BusinessLayer {
  public class clsUtilites {
    public static string ComputeHash(string input) {
      using(SHA256 sHA256 = SHA256.Create()) {
        byte[] hashBytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(input));

        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
      }
    }
  }
}
