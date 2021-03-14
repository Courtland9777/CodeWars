using System.Linq;
public class Kata
{
  public static string Repeater(string s, int n)
  {
    return string.Join("", Enumerable.Repeat(s, n));
  }
}