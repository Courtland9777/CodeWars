using System;
using System.Linq;

public static class Kata
{
  public static bool Compare(string s1, string s2)
  { 
     int v1 = s1 is null || s1.ToCharArray().Any(x => !char.IsLetter(x))
          ? 0
          : s1.ToUpper().ToCharArray().Sum(x => x);
      int v2 = s2 is null || s2.ToCharArray().Any(x => !char.IsLetter(x))
          ? 0
          : s2.ToUpper().ToCharArray().Sum(x => x);
      return v1 == v2; 
  }
}