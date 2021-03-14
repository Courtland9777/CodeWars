using System;
using System.Linq;
public class Recursion
{
  public static ulong Factorial(ulong n)
  {
    checked
    {
      return n == 0 || n == 1 ? 1 : n * Factorial(n -1);
    }
  }
}