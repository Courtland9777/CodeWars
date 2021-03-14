using System;

public class CodeWars
{
  public static bool IsDigit(string s) 
  {
    return double.TryParse(s, out double result);
  }
}