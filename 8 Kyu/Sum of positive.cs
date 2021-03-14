using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    return arr.Where(m => m > 0).Sum(o => o);
    return 0;
  }
}