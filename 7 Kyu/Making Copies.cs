using System;
using System.Collections.Generic;
using System.Linq;
public static class ListExtensions
{
  public static List<T> Copy<T>(this List<T> lst)
  {
    return lst.Select(x => x).ToList();
  }
}