using System;
public class Kata
{
  public static string Reverse(string text)
  {
    string[] arr = text.Split(' ');
    Array.Reverse(arr);
    return string.Join(" ", arr);
  }
}