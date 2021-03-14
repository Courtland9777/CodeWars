using System;
using System.Collections.Generic;
using System.Numerics;

public class Kata
{
  public static BigInteger[] PowersOfTwo(int n)
  {
    var list = new List<BigInteger>();
    for (int i = 0; i <= n; i++)
    {
        list.Add((BigInteger)Math.Pow(2,i));
    }
    return list.ToArray();
  }
}