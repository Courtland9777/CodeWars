using System.Linq;
public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    return Enumerable.Range(1, m).Select(x => x * n).ToArray();
  }
}