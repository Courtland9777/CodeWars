using System;
using System.Linq;
public class Kata
{
  public static string SortMyString(string s)
  {
    return $"{new string(s.Where((x, i) => i % 2 == 0).ToArray())} {new string(s.Where((x, i) => i % 2 != 0).ToArray())}";
  }
}