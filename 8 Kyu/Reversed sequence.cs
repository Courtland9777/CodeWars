using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int[] arr = new int[n];
    for (int i = arr.Length -1; i >= 0; i--)
    {
        arr[i] = i+1;
    }
    Array.Reverse(arr);
    return arr;
  }
}