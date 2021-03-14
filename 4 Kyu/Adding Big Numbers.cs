using System;
using System.Numerics;

public class Kata
{
  public static string Add(string a, string b)
  {
    BigInteger aInt;
    BigInteger bInt;
    
    BigInteger.TryParse(a, out aInt);
    BigInteger.TryParse(b, out bInt);
    
    return (aInt + bInt).ToString();
  }
}