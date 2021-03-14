using System;
using System.Linq;

public class Kata
{
  public static int HexToDec(string hexString)
  {
      return hexString.Contains("-") ? -1 * int.Parse(hexString.Replace("-", ""), System.Globalization.NumberStyles.HexNumber) :
                int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
  }
}