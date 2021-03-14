using System;
using System.Linq;
using System.Collections.Generic;

public class Kata {
  public static IEnumerable<int> MenFromBoys(int[] arr)
{
    List<int> men = new List<int>();
    List<int> boys = new List<int>();

    var numberGroups = arr.Distinct().GroupBy(p => Math.Abs(p) % 2);
    foreach (var grp in numberGroups)
    {
        var number = grp.Key;

        if (number == 0)
        {
            men = grp.OrderBy(n => n).ToList();
        }
        else if (number == 1)
        {
            boys = grp.OrderByDescending(n => n).ToList();
        }
    }
    return men.Concat(boys);
}
}