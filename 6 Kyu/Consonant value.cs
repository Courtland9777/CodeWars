using System;
using System.Linq;

public class Kata
{
    public static int Solve(string s)
    {
        var arr = s.Split('a', 'e', 'i', 'o', 'u');
        int max = 0;
        foreach (var s1 in arr)
        {
            int temp = s1.ToCharArray().Sum(x => (x-96));
            if (temp > max) max = temp;
        }
        return max;
    }
}