using System;
using System.Linq;
public class Solution
{
	//Solution intentionally avoids using a 26 character alphabet string.
    public static bool solve(string s) =>
      s.ToCharArray().Distinct().Count() == s.Length &&
        ((s.ToCharArray().Select(Convert.ToInt32).Aggregate((a, b) => a + b)) -
        Enumerable.Range(1, s.Length - 1).Aggregate(0, (p, item) => p + item)) %
        s.ToCharArray().Min(Convert.ToInt32) == 0;
    
}