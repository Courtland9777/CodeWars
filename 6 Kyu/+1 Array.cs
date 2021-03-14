using System;
using System.Linq;
using System.Numerics;
namespace Kata
{
  public static class Kata
  {
    public static int[] UpArray(int[] num)
    {
      //foreach (var item in num)
      //{
      //    Console.WriteLine(item);
      //}
      if (num.Length == 0) return null;
      foreach (var p in num)
      {
          if (!(p >= 0 && p < 10))
          {
              return null;
          }
      }
      int i = 0;
      while (num[i] == 0)
      {
          i++;
      }

      var leading = i > 0 ? string.Concat(Enumerable.Repeat("0", i)) : "";
      var s = $"{leading}{BigInteger.Parse(string.Concat(num)) + 1}";
      return s.Select(x => (int)char.GetNumericValue(x)).ToArray(); ;
    }
  }
}