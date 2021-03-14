public static class Kata
{
  public static int Solution(int value)
  {
      int total = 0;
      for (int i = 3; i < value; i++)
      {
          if(i % 3 == 0)
          {
              total += i;
              continue;
          }
          if(i % 5 == 0)
          {
              total += i;
              continue;
          }
      }
      return total;
  }
}