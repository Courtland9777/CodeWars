using System;

public static class Kata
{
  public static long SumCubes(int n)
  {
    long result = 0;
    for (int i = n; i >= 1; i--)
    {
        result += (long) Math.Pow(i, 3);
    }
    return result;
  }
}