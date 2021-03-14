using System;
using System.Linq;

public class Kata
{
  public static int SumDigits(int number)
  {
    return Math.Abs(number).ToString().ToArray().Sum(x => int.Parse(x.ToString()));
  }
}