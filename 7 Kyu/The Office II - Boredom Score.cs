using System.Collections.Generic;
using System.Linq;
public class Kata
{

  public static string Boredom(Dictionary<string, string> staff)
  {
      int total = Score(staff.Select(x => x.Value));
      return total <= 80 ? "kill me now" : total < 100 && total > 80 ? "i can handle this" : "party time!!";
  }

  private static int Score(IEnumerable<string> jobs)
  {
      var dict = new Dictionary<string, int>
      {
          { "accounts", 1 },
          { "finance", 2 },
          { "canteen", 10 },
          { "regulation", 3 },
          { "trading", 6 },
          { "change", 6 },
          { "IS", 8 },
          { "retail", 5 },
          { "cleaning", 4 },
          { "pissing about", 25 }
      };

      return jobs.Sum(x => dict[x]);
  }
}