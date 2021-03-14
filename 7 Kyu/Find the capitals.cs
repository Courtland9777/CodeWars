using System;
using System.Collections.Generic;

public static class Kata
{
  public static int[] Capitals(string word)
  {
    var arr = word.ToCharArray();
    var list = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (char.IsUpper(arr[i])) list.Add(i);
    }

    return list.ToArray();
  }
}