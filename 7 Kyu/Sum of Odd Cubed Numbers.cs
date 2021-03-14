using System;
using System.Linq;
public class Kata
{
  public static int CubeOdd(int[] arr)
  {
    return arr.Select(x => (int)Math.Pow((double)x, 3)).Where(x => x % 2 != 0).Sum();
  }
}