using System;
using System.Linq;
public class CountDig 
{
    public static int NbDig(int n, int d) => string.Concat(Enumerable.Range(0, n+1).Select(x => ((int) Math.Pow(x, 2)).ToString())).Count(p => d.ToString() == p.ToString());
}