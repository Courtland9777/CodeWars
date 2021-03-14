using System;
using System.Linq;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    int dupCount = 0;
    var arr = str.ToLower().ToCharArray();
    foreach (var letter in arr.GroupBy(x => x)
                              .Select(group => new {
                                   Letter = group.Key,
                                   Count = group.Count()
                               }))
    {
        if (letter.Count > 1) dupCount++;
    }

    return dupCount;
  }
}