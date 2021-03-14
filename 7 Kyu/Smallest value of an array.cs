using System;
using System.Linq;
public class Kata
{
  public static int FindSmallest(int[] numbers, string toReturn) =>
      toReturn.Equals("value") ? numbers.Min() : Array.IndexOf(numbers, numbers.Min());
}