using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] VowelIndices(string word)
  {
    var arr = word.ToLower().ToCharArray();
    var list = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if ("aeiouy".Contains(arr[i]))
            list.Add(i+1);
    }

    return list.ToArray();
  }
}