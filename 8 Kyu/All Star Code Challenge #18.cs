using System.Linq;
class Kata
{
    public static int StrCount(string str, string letter)
    {
        return str.ToCharArray().Count(x => x.ToString().Equals(letter));
    }
}