using System;
using System.Linq;
public class Kata {
  public static int MaxProduct(int[] arr, int size) =>
    arr.OrderByDescending(x => x).Take(size).Aggregate((a, b) => a * b);
}