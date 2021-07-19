using System;
using System.Linq;
using System.Collections.Generic;
class SumParts
{

    public static int[] PartsSums(int[] ls)
    {
      var currentSum = ls.Sum();
      var list = new List<int>
      {
          currentSum
      };
      
      foreach (var t in ls)
      {
          currentSum -= t;
          list.Add(currentSum);
      }

      return list.ToArray();
    }
}