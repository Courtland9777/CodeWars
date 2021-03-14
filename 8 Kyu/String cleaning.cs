using System.Linq;

public class Kata
{
  public static string StringClean(string s)
  {
    return string.Concat(s.Where(x => !char.IsNumber(x)));
  }
}