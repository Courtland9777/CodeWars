using System.Linq;
class Kata
{
    public static long MinValue(int[] a)
    {
        return long.Parse(string.Join("",a.Distinct().OrderBy(x => x.ToString())));
    }
}