using System.Linq;
class Kata
{
    public static bool TidyNumber(int n) => n == int.Parse(string.Concat(n.ToString().ToCharArray().OrderBy(o => o)));
}