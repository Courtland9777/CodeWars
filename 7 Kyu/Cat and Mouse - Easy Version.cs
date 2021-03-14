using System;

public class Kata
{
  public static string CatMouse(string x) => x.IndexOf('m') - x.IndexOf('C') > 4 ? "Escaped!" : "Caught!";
}