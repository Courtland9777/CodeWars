using System;
using System.Linq;
public static class Kata
{
  public static int MaxGap(int[] numbers)
  {
    var arr = numbers.OrderBy(n => n).ToArray();
    return arr.Take(numbers.Length - 1).Select((v, i) => arr[i + 1] - v).Max();
  }
}