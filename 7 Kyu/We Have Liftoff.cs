using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  public static string Liftoff(List<int> instructions) => $"{string.Join(" ", instructions.OrderByDescending(o => o))} liftoff!";
}