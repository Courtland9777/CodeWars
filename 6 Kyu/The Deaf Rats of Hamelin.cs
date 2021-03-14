using System;
using System.Linq;
public class Dinglemouse
{
  public static int CountDeafRats(string town)
  {
      var arr = town.Replace(" ", "").Split('P');
      int left = 0, right = 0;
      if (arr[0].Length != 0)
      {
          left = (arr[0].Length/2) - arr[0].ToCharArray().Where((c, i) => i % 2 == 0)
              .Count(x => x.Equals('~'));
      }
      if (arr[1].Length != 0)
      {
          right = (arr[1].Length / 2) - arr[1].ToCharArray().Where((c, i) => i % 2 != 0)
                     .Count(x => x.Equals('~'));
      }

      return left + right;
  }
}