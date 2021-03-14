using System;
using System.Linq;

public class Kata
{
  public static bool ValidateCode(string code) => !string.IsNullOrEmpty(code) && char.IsDigit(code[0]) && (int.Parse(code[0].ToString()) > 0 && int.Parse(code[0].ToString()) < 4);
}