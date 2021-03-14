using System;
using System.Linq;
public class NewAverage
{
    public static long NewAvg(double[] arr, double navg)
    {
        var don = (long)Math.Ceiling((navg * (arr.Length + 1)) - arr.Sum());
        return don <= 0 ? throw new ArgumentException() : don;
    }
}