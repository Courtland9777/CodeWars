using System.Linq;
public class Kata
{
  public static string Contamination(string text, string character)
  {
    return string.Concat(Enumerable.Repeat(character, text.Length));
  }
}