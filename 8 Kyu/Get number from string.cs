using System;
using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static int getNumberFromString(string s)
    {
      return int.Parse(string.Concat(s.Where(char.IsDigit)));
    }
  }
}