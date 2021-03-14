using System;
using System.Linq;
class Kata
{
    public static int MaxTriSum(int[] arr) =>
      arr.OrderByDescending(x => x).Distinct().Take(3).Aggregate((a, b) => a + b);
}