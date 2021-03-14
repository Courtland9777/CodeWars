using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
      string[] arr = numbers.Split(' ');
      int[] intArr = new int[arr.Length];
      for(int i = 0; i < intArr.Length; i++)
      {
          intArr[i] = Int32.Parse(arr[i]);
      }
      return intArr.Max() + " " + intArr.Min();
  }
}