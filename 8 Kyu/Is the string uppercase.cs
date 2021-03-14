using System.Linq;
public static class StringExtensions
{
  public static bool IsUpperCase(this string text)
  {
    return text.Where(char.IsLetter).All(char.IsUpper);
  }
}