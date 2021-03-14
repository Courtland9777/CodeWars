using System;

public static class Kata
{
  public static bool IsDivisible(int wallLength, int pixelSize)
  {
    return wallLength % pixelSize == 0;
  }
}