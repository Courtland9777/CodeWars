using System;
using System.Linq;
public static class Kata
{
  public static int GetMissingElement(int[] superImportantArray) =>
    Enumerable.Range(0,10).FirstOrDefault(n=> !superImportantArray.Contains(n));
}