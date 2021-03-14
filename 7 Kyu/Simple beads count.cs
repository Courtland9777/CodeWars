using System;

public static class Kata
{
  public static int CountRedBeads(int n)
  {
    return n < 2 ? 0 : n == 2 ? 2 : (n - 1) * 2;
  }
}