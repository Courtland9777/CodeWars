using System;

public static class Kata
{
  public static double CalculateAreaOfCircle(string radius)
  {
      double.TryParse(radius, out var r);
      return r < 1 || radius.Contains(",") ? throw new ArgumentException() : Math.Round(Math.PI * Math.Pow(r,2),2);
  }
}