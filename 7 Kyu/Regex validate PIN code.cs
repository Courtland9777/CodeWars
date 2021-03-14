using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    if(pin.Length != 4 && pin.Length != 6) return false;
    char[] arr = pin.ToCharArray();
    return !(Array.Exists(arr, element => element < '0' || element > '9'));
  }
}