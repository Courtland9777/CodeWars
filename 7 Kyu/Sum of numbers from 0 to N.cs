using System.Linq;

public class SequenceSum
{
  public static string ShowSequence(int n)
  {    
    if (n == 0) return "0=0";
    if (n < 0) return $"{n}<0";
    return $"{string.Join("+",Enumerable.Range(0, n + 1).ToArray())} = {Enumerable.Range(0, n + 1).Sum()}";  }
}