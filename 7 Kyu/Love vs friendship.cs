using System;

public static class Kata
{
  public static int WordsToMarks(string str)
  {
    var arr = str.ToCharArray();
    int retSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        retSum += arr[i] - 'a';
    }

    return retSum + arr.Length;
  }
}