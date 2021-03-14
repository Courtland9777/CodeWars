using System;
public class Kata
{
  public static string MouthSize(string animal)
  {
    return animal.Equals("alligator", StringComparison.OrdinalIgnoreCase) ? "small" : "wide";
  }
}