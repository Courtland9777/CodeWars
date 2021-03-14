using System;
using System.Linq;
class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    return a != null && b != null && a.Length == b.Length && b.OrderBy(n=>n).SequenceEqual(a.OrderBy(p=>p).Select(i => i*i).ToArray());
  }
}