using System;
using System.Linq;

public class Kata
{
  public static bool ValidateUsr(string username) 
  {
    return username.Length > 3 && 
           username.Length < 17 && 
           username.All(c => !char.IsUpper(c) && char.IsLetterOrDigit(c) || c.Equals('_'));
  }
}