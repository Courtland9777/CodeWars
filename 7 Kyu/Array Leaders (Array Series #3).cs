using System;
using System.Linq;
public static class Kata
{
  public static int[] ArrayLeaders(int[] n)
  {
    return n.Where((t, i) => t > n.Skip(i + 1).Sum()).ToArray();
  }
}