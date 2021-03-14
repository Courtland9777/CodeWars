using System;

public static class Kata
{
  public static string EvensAndOdds(int num) =>
    num % 2 == 0 ? Convert.ToString(num, 2) : Convert.ToString(num, 16);
}