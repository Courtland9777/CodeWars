using System;
using System.Linq;
public static class Kata
{
  public static string Swap(string s)
  {
    return string.Concat(s.Select(c => "aeiou".Contains(c) ? char.ToUpper(c) : c));
  }
}