using System;
using System.Linq;

public class Kata
{
  public static int FindDifference(int[] a, int[] b)
  {
    return Math.Abs(a.Aggregate((n, m) => n * m) - b.Aggregate((n, m) => n * m));
  }
}