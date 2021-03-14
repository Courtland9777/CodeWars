using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  public static int? UniqueSum(List<int> lst) => lst.Count > 0 ? lst.Distinct().Sum() : (int?)null;
}