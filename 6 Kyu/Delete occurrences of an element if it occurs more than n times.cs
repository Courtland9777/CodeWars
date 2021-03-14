using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {
  public static int[] DeleteNth(int[] arr, int x) 
  {
    List<int> list = arr.ToList();
    var dict = new Dictionary<int, int>();
    foreach (var item in arr)
    {
        if(dict.ContainsKey(item))
        {
            dict[item]++;
        }
        else
        {
            dict.Add(item,1);
        }
    }
    list.Reverse();
    var removeList = new List<int>();
    foreach (var val in list)
    {
        if(dict[val] > x)
        {
            removeList.Add(val);
            dict[val]--;
        }
    }
    foreach (var val in removeList)
    {
        list.Remove(val);
    }
    list.Reverse();
    return list.ToArray();
  }
}