using System;

public static class Kata
{
  public static string Replace(string s)
  {
    return s.Replace("a", "!").Replace("A", "!").Replace("e", "!").Replace("E", "!").Replace("i", "!")
                .Replace("I", "!").Replace("o", "!").Replace("O", "!").Replace("U", "!").Replace("u", "!");
  }
}