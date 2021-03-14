using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static long ListPosition(string value)
    {
        var array = value.ToCharArray();
        var sorted = array.OrderBy(c => c).ToArray();
        var position = 1L;

        var unique = sorted.GroupBy(c => c).Select(cc => cc.Key).ToArray();
        int i = 0, j = 0;
        while (i < array.Length || j < unique.Length)
        {
            if (array[i] == unique[j++])
            {
                var tmp = sorted.ToList();
                tmp.Remove(array[i]);
                sorted = tmp.ToArray();
                unique = sorted.GroupBy(c => c).Select(cc => cc.Key).ToArray();
                i++;
                j = 0;
            }
            else
            {
                var _sorted = sorted.ToList();
                _sorted.Remove(array[i] < unique[j - 1] ? array[i] : unique[j - 1]);
                var c = CountAnagrams(_sorted.ToArray());
                position += c;
            }
        }
        return position;
    }

    private static long F(int n)
    {
        return n == 0 ? 1 : F(n - 1) * n;
    }

    private static long CountAnagrams(char[] word)
    {
        var groupsCount = word.GroupBy(c => c).Select(cc => cc.Count()).ToList();
        var numerator = F(word.Length);
        var denominator = groupsCount.Aggregate<int, long>(1, (current, t) => current * F(t));
        return numerator / denominator;
    }    
}