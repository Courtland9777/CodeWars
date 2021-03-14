using System;
using System.Collections.Generic;
using System.Linq;

public class RangeExtraction
{
    public static string Extract(int[] arr)
    {
        var result = String.Join(",", RangesToStrings(GetRanges(arr)));
        return result;
    }

    public static IEnumerable<IEnumerable<int>> GetRanges(int[] numbers)
    {
        var current = new List<int>();
        foreach (var n in numbers)
        {
            if (current.Count == 0)
            {
                current.Add(n);
            }
            else
            {
                if (current.Max() + 1 == n)
                {
                    current.Add(n);
                }
                else
                {
                    yield return current;
                    current = new List<int> { n };
                }
            }
        }
        yield return current;
    }

    public static IEnumerable<string> RangesToStrings(IEnumerable<IEnumerable<int>> ranges)
    {
        foreach (var range in ranges)
        {
            if (range.Count() == 1)
            {
                yield return range.Single().ToString();
            }
            else if (range.Count() == 2)
            {
                yield return range.Min() + "," + range.Max();
            }
            else
            {
                yield return range.Min() + "-" + range.Max();
            }
        }
    }
}