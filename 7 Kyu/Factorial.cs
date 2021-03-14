using System;
using System.Linq;
namespace Solution
{
  public static class Program
  {
    public static int factorial(int n)
    {
      return n == 0 ? 1 : Enumerable.Range(1, n).Aggregate((a,b) => a * b);
    }
  }
}