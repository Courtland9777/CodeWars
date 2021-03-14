using System;
public static class Kata 
{
  public static bool IsLockNessMonster(string sentence) 
  {
    return sentence.IndexOf("tree fiddy", StringComparison.OrdinalIgnoreCase) >= 0 || sentence.Contains("3.50");
  }
}