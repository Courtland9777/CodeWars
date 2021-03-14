using System;
public class Kata
{
  public static int CloseCompare(double a, double b, double margin = 0) => Math.Abs(a - b) <= margin ? 0 : a < b ? -1 : 1;
}