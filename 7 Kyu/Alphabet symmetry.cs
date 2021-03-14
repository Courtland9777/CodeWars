using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> Solve(List<string> arr)
  {
    var list = new List<int>();
    foreach (var item in arr)
    {
        var charArr = item.ToLower().ToCharArray();
        int counter = 0;
        for (int i = 0; i < item.Length; i++)
        {
            if (charArr[i] == (char) 97 + i) counter++;
        }
        list.Add(counter);
    }

    return list;
  }
}