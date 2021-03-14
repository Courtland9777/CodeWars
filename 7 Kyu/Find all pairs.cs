using System.Linq;
class Kata
{
    public static int Duplicates(int[] a) =>
        a.GroupBy(k => k).Sum(x => x.Count() % 2 == 0 ? x.Count() / 2 : (x.Count() - 1) / 2);
}