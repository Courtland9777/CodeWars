using System;

public static class Kata
{
  public static string CountSheep(int n)
  {
    string sheep = "";
    for (int i = 0; i < n; i++)
    {
        sheep += String.Format("{0} sheep...", (i + 1));
    }
    return sheep;
  }
}