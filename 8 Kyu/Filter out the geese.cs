using System.Collections.Generic;
using System.Linq;
public static class Filter
{
  public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
  {
    string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
    return birds.Where(x => !geese.Contains(x));
  }
}