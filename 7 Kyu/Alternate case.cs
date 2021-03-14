using System;
using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static string alternateCase(string s) =>
      string.Concat(s.Select(x => char.IsLower(x) ? char.ToUpper(x).ToString() : char.ToLower(x).ToString()));
  }
}