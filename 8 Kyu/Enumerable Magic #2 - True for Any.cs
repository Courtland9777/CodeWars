using System;
using System.Linq;
public class Kata
{
  public static bool Any(int[] arr, Func<int,bool> fun) => arr.Select(x => fun(x)).Any(s => s);
}