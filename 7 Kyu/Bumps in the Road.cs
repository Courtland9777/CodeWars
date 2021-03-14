using System.Linq;

class Kata
{
    public static string Bump(string input)
    {
        return input.ToCharArray().Count(x => x == 'n') < 15 ? "Woohoo!" : "Car Dead";
    }
}