using System.Linq;
public class Kata
{
  public static string Switcheroo(string x) =>
    string.Concat(x.Select(c => c.Equals('c') ? 'c' : c.Equals('b') ? 'a' : 'b'));
}