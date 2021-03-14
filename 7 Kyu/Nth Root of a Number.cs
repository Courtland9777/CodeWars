using System;
namespace NthRoot
{
  public class Kata
  {
    public static double FindRoot(double x, int n) =>
      Math.Pow(x, 1.0 / n);
  }
}