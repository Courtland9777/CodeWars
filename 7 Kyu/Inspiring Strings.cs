using System.Linq;
public class Kata
{
  public static string LongestWord(string stringOfWords)
  {
    return stringOfWords.Split(' ').Aggregate(string.Empty, (seed, f) => f.Length >= seed.Length ? f : seed);
  }
}