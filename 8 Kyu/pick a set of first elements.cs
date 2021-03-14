using System;
using System.Linq;
public class Kata
{
  public static object[] TakeFirstElements(object[] array, int n = 1) =>
     array.Length < 1 ? Array.Empty<object>() : array.Take(n).ToArray();
}