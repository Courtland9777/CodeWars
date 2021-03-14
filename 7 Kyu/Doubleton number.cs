using System.Linq;
public static class Kata
{
    public static int Doubleton(int num) =>
      Enumerable.Range(num + 1, 1000000 - (num + 1)).First(x => x.ToString().ToCharArray().Distinct().Count() == 2);
}