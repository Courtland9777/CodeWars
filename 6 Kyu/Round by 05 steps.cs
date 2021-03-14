using System;
public class Kata
{
  public static double Solution(double n)
  {
    return Math.Round(n * 2, MidpointRounding.AwayFromZero) / 2;
  }
}