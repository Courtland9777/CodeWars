using System;
using System.Linq;
class Rainfall 
{
    private static string[] townList = new string [] {"Rome", "London", "Paris", "NY", "Vancouver", "Sydney", "Bangkok", "Tokyo",
        "Beijing", "Lima"};
        
    public static double Mean(string town, string strng) 
    {
        return !townList.Contains(town) ? -1 :
            strng.Split(new [] {"\n"}, StringSplitOptions.None)
            .First(x => x.Contains(town)).Substring(town.Length + 1).Split(',')
            .Average(v => double.Parse(v.Substring(4)));
    }
    
    public static double Variance(string town, string strng)
    {
        if (!townList.Contains(town)) return -1;
        var arr = strng.Split(new[] {"\n"}, StringSplitOptions.None)
            .First(x => x.Contains(town)).Substring(town.Length + 1).Split(',')
            .Select(v => double.Parse(v.Substring(4))).ToArray();

        return arr.Sum(val => Math.Pow(val - arr.Average(), 2)) / arr.Length;
    }
}