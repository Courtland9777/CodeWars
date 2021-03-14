using System;
using System.Linq;
public class Kata
{
  public static string BandNameGenerator(string str)
  {
    return str[0].Equals(str[str.Length-1])
        ? $"{char.ToUpper(str[0])}{str.Substring(1)}{str.Substring(1)}"
        : $"The {char.ToUpper(str[0])}{str.Substring(1)}";
  }
}