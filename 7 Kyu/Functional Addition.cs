using System;

public static class Kata
{
  public static Func<double, double> Add(double n)
  {
    return new Func<double, double>(x => x + n);
  }
}