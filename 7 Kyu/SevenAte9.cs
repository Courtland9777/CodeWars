 using System;

public class Kata
{
  public static string SevenAteNine(string str)
  {
    int len = str.Length;
    do
    {
        len = str.Length;
        str = str.Replace("797", "77");
    } while (str.Length != len);
    return str;
  }
}