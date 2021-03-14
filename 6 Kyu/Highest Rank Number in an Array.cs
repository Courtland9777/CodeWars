using System.Linq;
public class Kata
{
  public static int HighestRank(int[] arr)
  {
    return arr.GroupBy(g => g).OrderByDescending(o => o.Count()).ThenByDescending(k=>k.Key).Select(k => k.Key).First();
  }
}