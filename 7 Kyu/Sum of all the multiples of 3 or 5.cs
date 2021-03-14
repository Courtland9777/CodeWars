namespace Solution
{
  public static class Program
  {
    public static int findSum(int n)
    {
      int Sum = 0;
      for (int i = n; i > 0; i--)
      {
          if (i % 3 == 0 || i % 5 == 0) Sum += i;
      }
      return Sum;
    }
  }
}