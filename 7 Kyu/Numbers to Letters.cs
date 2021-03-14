using System;
using System.Linq;
public class Kata
{
    public static string Switcher(string[] x) =>
    string.Concat(x.Select(c =>
      int.Parse(c) < 27 ? Convert.ToChar((27 - int.Parse(c)) + 96) 
      : int.Parse(c) == 27 ? '!' : int.Parse(c) == 28 ? '?' : ' '));
}