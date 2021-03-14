using System;
using System.Linq;
public class Kata
{
  public static int Average(int[] scores)
  {
    return (int)Math.Round(scores.Average());
  }
}