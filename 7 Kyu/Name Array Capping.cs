using System;
using System.Linq;
public static class Kata
{
  public static string[] CapMe(string[] strings) =>
    strings.Select(x => $"{char.ToUpper(x.First())}{x.Substring(1).ToLower()}").ToArray();
}