using System;
using System.Linq;

public static class Kata
{
  public static int MaxSequence(int[] arr)
  {
      if (arr.Length == 0 || arr.All(x => x < 1)) return 0;
      if (arr.All(x => x > 0)) return arr.Sum();
      int n = arr.Length;
      return MaxSubArraySum(arr, 0, n - 1);
  }
  
  private static int MaxCrossingSum(int[] arr, int l, int m, int h)
  {
      int sum = 0;
      int leftSum = int.MinValue;
      for (int i = m; i >= l; i--)
      {
          sum = sum + arr[i];
          if (sum > leftSum)
              leftSum = sum;
      }
  
      sum = 0;
      int rightSum = int.MinValue; ;
      for (int i = m + 1; i <= h; i++)
      {
          sum = sum + arr[i];
          if (sum > rightSum)
              rightSum = sum;
      }
  
      return leftSum + rightSum;
  }
  
  private static int MaxSubArraySum(int[] arr, int l, int h)
  {
      if (l == h) return arr[l];
  
      int m = (l + h) / 2;
  
      return Math.Max(Math.Max(MaxSubArraySum(arr, l, m),
              MaxSubArraySum(arr, m + 1, h)),
              MaxCrossingSum(arr, l, m, h));
  }
}