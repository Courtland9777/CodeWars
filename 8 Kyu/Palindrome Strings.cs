using System.Linq;
public class Kata
{
  public static bool IsPalindrome(object line)
  {
    return line.ToString().Equals(string.Concat(line.ToString().ToCharArray().Reverse()));  
  }
}