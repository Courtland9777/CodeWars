using System;
using System.Linq;
public class Kata
{
  public static int SumMix(object[] x)
  {
    var arr = new int[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        arr[i] = int.Parse(x[i].ToString());
    }

    return arr.Sum();
  }
}