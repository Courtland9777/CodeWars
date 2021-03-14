using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    return number < 1? number : number * -1;
  }
}