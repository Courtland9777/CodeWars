using System;
public class Kata
{
  public static int RoundToNext5(int n)
  {
    if(n >= 0) return n % 5 == 0 ? n : n + (5 - (n % 5));
    return n % 5 == 0 ? n : n - (n % 5);
  }
}