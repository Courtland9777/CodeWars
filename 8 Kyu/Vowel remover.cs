using System.Linq;
public class Kata
{
  public static string Shortcut(string input)
  {
    var vowels = "aeiou";
    return string.Concat(input.ToCharArray().Where(x => !vowels.Contains(x)));
  }
}