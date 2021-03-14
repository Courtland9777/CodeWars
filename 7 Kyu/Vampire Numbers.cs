using System;
using System.Linq;

static class Kata{
  public static bool vampire_test(long x, long y) =>
      string.Concat($"{x}{y}".OrderBy(n => n)).Equals(string.Concat((x * y).ToString().OrderBy(n => n)));
}