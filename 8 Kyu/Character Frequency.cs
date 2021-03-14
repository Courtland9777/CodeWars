using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static Dictionary<char, int> CharFreq(string message)
  {
    return message.GroupBy(o => o).ToDictionary(g => g.Key, g => g.Count());
  }
}