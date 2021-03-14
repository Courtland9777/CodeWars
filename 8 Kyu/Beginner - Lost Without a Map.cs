using System.Linq;

public class Kata
{
  public static int[] Maps(int[] x)
  {
    return x.Select(c => c * 2).ToArray();
  }
}