public static class Kata
{
  public static int SequenceSum(int start, int end, int step)
  {
    if (start > end) return 0;
    int Sum = 0;
    for (int i = start; i <= end; i+=step)
    {
        Sum += i;
    }
    return Sum;
  }
}