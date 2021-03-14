using System;
using System.Linq;
public class Kata
{
  public static double Index(int[] array, int n)
  {
    if (n >= array.Length) return -1;
    return Math.Pow(array[n], n);
  }
}