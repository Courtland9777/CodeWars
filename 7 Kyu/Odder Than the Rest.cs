using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static int OddOne(List<int> list)
  {
    try
    {
        return list.Select((v, i) => new { v, i }).First(l => l.v % 2 != 0).i;
    }
    catch (InvalidOperationException)
    {
        return -1;
    }
  }
}