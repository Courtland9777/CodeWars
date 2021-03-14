using System;
using System.Linq;
public class Kata
{
  public static long StairsIn20(int[][] stairs)
  {
    return stairs.SelectMany(item => item).Sum()*20;
  }
}