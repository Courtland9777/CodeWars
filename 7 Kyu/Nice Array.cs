using System;
using System.Linq;
public class Kata
{
  public static bool IsNice(int[] arr) =>
    arr.Length == 0 ? false : arr.All(x => arr.Contains(x + 1) || arr.Contains(x - 1));
}