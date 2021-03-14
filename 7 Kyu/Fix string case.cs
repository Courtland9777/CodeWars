using System.Linq;
class Kata
{
    public static string Solve(string s) =>
        s.Count(char.IsUpper) > s.Length - s.Count(char.IsUpper) ? s.ToUpper() : s.ToLower();
}