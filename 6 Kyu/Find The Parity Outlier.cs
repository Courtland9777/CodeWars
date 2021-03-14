using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    return integers.Count(x => x % 2 == 0) > 1
           ? integers.First(x => x % 2 == 1)
           : integers.First(x => x % 2 == 0);
  }
}