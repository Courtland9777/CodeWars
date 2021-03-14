using System.Linq;

public class OccurrencesKata
{
  public static int NumberOfOccurrences(int x, int[] xs) => xs.Count(y => y == x);
}