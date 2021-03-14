using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static List<int> MultipleOfIndex(List<int> xs)
  {
    int counter = 1;
    var list = new List<int>();
    foreach (var item in xs.Skip(1))
    {
        if(item % counter == 0) list.Add(item);
        counter++;
    }
    return list;
  }
}