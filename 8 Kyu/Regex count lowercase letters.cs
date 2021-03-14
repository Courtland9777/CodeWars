using System.Linq;
public class Kata
{
  public static int LowercaseCountCheck(string s)
  {
    return s.Count(x => char.IsLower(x));
  }
}