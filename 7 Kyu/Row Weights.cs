using System;
using System.Linq;
class Kata
{
    public static int[] RowWeights(int[] a)
    {
        return new int[] { a.Where((x, i) => i % 2 == 0).Sum(), a.Where((x, i) => i % 2 != 0).Sum() };
    }
}