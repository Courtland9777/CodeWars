using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static List<int> Odds(List<int> values) =>
    values.Where(x => x % 2 != 0)
          .ToList();
}