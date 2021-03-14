using System;
using System.Linq;
public class SequenceSum
{
  public static int[] SumOfN(int n)
  {
    int i = 0;
    return n == 0 ? new int[]{0} : n > 0 ? Enumerable.Range(0, Math.Abs(n + 1)).Select(x => i += x).ToArray() :
      Enumerable.Range(0, Math.Abs(n - 1)).Select(x => (i += x) * -1).ToArray();
  }
}