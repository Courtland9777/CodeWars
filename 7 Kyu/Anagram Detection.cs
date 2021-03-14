using System.Linq;
public class Kata
{
  public static bool IsAnagram(string test, string original)
  {
    return string.Concat(test.ToLower().OrderBy(c => c)).Equals(string.Concat(original.ToLower().OrderBy(c => c)));
  }
}