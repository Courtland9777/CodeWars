using System;

public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
    return name.Substring(0, 1).Equals("R") || name.Substring(0, 1).Equals("r")
                ? $"{name} plays banjo"
                : $"{name} does not play banjo";
  }
}