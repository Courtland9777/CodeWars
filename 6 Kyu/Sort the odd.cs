using System.Linq;
public class Kata
{
  public static int[] SortArray(int[] array)
  {
    var indexedNums = array.Select((num, idx) => new { num, idx }).ToList();
            var evens = indexedNums.Where(x => x.num % 2 == 0);
            var odds = indexedNums.Where(x => x.num % 2 == 1);
            var sortedOdds = odds.OrderBy(x => x.num);
            var reindexedOdds = sortedOdds.Zip(odds, (o1, o2) => new { o1.num, o2.idx });
            
            return evens.Concat(reindexedOdds).OrderBy(x => x.idx).Select(x => x.num).ToArray();
  }
}