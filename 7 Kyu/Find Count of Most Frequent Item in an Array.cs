using System.Linq;
public class Kata
{
  public static int MostFrequentItemCount(int[] collection) => collection.Length > 0 ? collection.GroupBy(e => e).Max(e => e.Count()) : 0;
}