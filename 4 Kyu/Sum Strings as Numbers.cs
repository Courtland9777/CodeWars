using System;
using System.Numerics;

public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      if (a.Length == 0) return b;
      if (b.Length == 0) return a;
      return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}