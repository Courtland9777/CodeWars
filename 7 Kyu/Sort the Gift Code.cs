using System.Linq;
public class Kata
{
  public static string SortGiftCode(string code) => string.Concat(code.OrderBy(x => x));
}