using System;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers)
  {
    if (numbers == null || numbers.Length == 0) {return 0;}
    
    return numbers.OrderBy(item => item)
    .Skip(1)
    .Reverse()
    .Skip(1)
    .Sum(item => item);
  }
}