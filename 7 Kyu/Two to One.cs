using System.Linq;
public class TwoToOne 
{
  public static string Longest (string s1, string s2) => string.Concat($"{s1}{s2}".Distinct().OrderBy(x => x));
}