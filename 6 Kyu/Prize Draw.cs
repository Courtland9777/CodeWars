using System;
using System.Collections.Generic;
using System.Linq;
public class Rank
{
    public static string NthRank(string st, int[] we, int n)
    {
        if (st.Length == 0) return "No participants";
        var arr = st.Split(',');
        if (n > arr.Length) return "Not enough participants";
        var list = new List<Tuple<string, int>>();
        for (int i = 0; i < arr.Length; i++)
        {
            int temp = arr[i].ToLower().Sum(c => (c - 96)) + arr[i].Length;
            temp *= we[i];
            list.Add(new Tuple<string, int>(arr[i], temp));
            temp = 0;
        }

        list = list.OrderByDescending(o => o.Item2).ThenBy(x => x.Item1).ToList();
        return list[n - 1].Item1;
    }
}