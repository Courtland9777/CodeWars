using System;
using System.Linq;
public static class Kata 
{
    public static string Swap(string str) => 
      string.Concat(str.Select(c => char.IsLower(c)?char.ToUpper(c):char.ToLower(c)));
}