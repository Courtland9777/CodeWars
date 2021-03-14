using System;
using System.Linq;
public class Kata
{
  public static string[] WordSearch(string query, string[] seq)
  {
    var arr = seq.Where(x => x.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToArray();
    return arr.Length == 0 ? new string[1] {"Empty"} : arr;
  }
}