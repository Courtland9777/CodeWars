using System;
using System.Linq;
public class Kata
{
  public static int Remainder(params int[] arr)
  {
    return arr.Min() == 0 ? throw new DivideByZeroException() : arr.Max() % arr.Min();
  }
}