using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    if (str.Equals("")) return new Dictionary<char, int>();
    var arr = str.ToCharArray();
    var dict = new Dictionary<char, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (dict.ContainsKey(arr[i]))
        {
            dict[arr[i]] += 1;
        }
        else dict.Add(arr[i], 1);
    }

    return dict;
  }
}