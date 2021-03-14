using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  public static Dictionary<string, int> Count(List<string> lst)
  {
    var dict = new Dictionary<string, int>();
    foreach (var item in lst.GroupBy(info => info)
                .Select(group => new {
                    Value = group.Key,
                    Count = group.Count()
                }))
    {
        dict.Add(item.Value, item.Count);
    }
    return dict;
  }
}