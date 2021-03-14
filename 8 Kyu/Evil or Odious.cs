using System;
using System.Linq;
public class Kata
{
  public static string Evil(int n)
  {
    return Convert.ToString(n, 2).Count(x => x.Equals('1')) % 2 == 0 ? "It's Evil!": "It's Odious!";
  }
}