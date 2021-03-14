using System;
using System.Linq;
public static class Kata
{
  public static string GenerateShape(int n)
  {
      string str = string.Empty;
      for (int i = 0; i < n; i++)
      {
          if (i==n-1)
          {
              str += $"{string.Concat(Enumerable.Repeat("+", n))}";
              continue;
          }
          str += $"{string.Concat(Enumerable.Repeat("+", n))}\n";
      }
      return str;
  }
}