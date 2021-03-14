using System;
using System.Linq;
public class Kata
{
  public static int DifferenceOfSquares(int n)
  {
    return (int)Math.Pow(Enumerable.Range(1, n).Sum(),2) - Enumerable.Range(1, n).Aggregate((a, b) => a + (b * b));
  }
}