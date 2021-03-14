using System.Collections.Generic;
using System.Linq;
public static class SumOfK 
{
    public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
    {
        var enumerable = elements as T[] ?? elements.ToArray();
        return k == 0 ? new[] { new T[0] } :
            enumerable.SelectMany((e, i) =>
                enumerable.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));
    }
    public static int? chooseBestSum(int maxDistance, int amountCountry, List<int> ts)
    {
        var result = Combinations(ts, amountCountry).ToList();
        result.RemoveAll(n => n.ToList().Sum() > maxDistance);
        if (result.Count == 0)
            return null;
        else
            return result.Max(m => m.Sum());
    }
}