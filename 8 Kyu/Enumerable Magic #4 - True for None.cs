using System;
using System.Linq;
public class Kata
{
  public static bool None(int[] arr, Func<int, bool> fun) =>
    arr.All(n => !fun(n));
}