using System;
using System.Globalization;
class Kata
{
    public static string Automorphic(int n)
    {
        var sqr = Math.Pow(n, 2).ToString(CultureInfo.InvariantCulture);
        return n.ToString().Equals(sqr.Substring(sqr.Length - n.ToString().Length)) ? "Automorphic" : "Not!!";
    }
}