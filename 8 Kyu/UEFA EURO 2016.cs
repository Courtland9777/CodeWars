public class Kata
{
  public static string UefaEuro2016(string[] t, int[] s)
  {
    return s[0] == s[1] ? $"At match {t[0]} - {t[1]}, teams played draw." : s[0] > s[1] ? $"At match {t[0]} - {t[1]}, {t[0]} won!" : $"At match {t[0]} - {t[1]}, {t[1]} won!";
  }
}