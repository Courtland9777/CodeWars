using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        var list = new List<string>();
        for (int i = 0; i < data.Length; i++)
        {
            if(data[i][0] > 54 && data[i][1] > 7) list.Add("Senior");
            else list.Add("Open");
        }
        return list;
    }
}