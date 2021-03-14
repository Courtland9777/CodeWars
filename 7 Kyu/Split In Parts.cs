using System;
using System.Linq;
public class Kata
{
  public static string SplitInParts(string s, int n) =>
    string.Concat(s.Select((x, i) => i > 0 && i % n == 0 ? $" {x}" : x.ToString()));
}  