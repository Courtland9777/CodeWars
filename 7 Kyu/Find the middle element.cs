using System.Linq;
public class Kata
{
  public static int Gimme(double[] inputArray)
  {
    return inputArray.Select((s, i) => new {i, s})
                     .Where(t => t.s == inputArray.OrderBy(x => x).ElementAt(1))
                     .Select(t => t.i).First();
  }
}