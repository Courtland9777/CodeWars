using System;

public static class Kata
{
  public static bool PowerOfTwo(int x)
  {
    return (x != 0) && ((x & (x - 1)) == 0);
  }
}