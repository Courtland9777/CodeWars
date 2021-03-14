using System;
using System.Collections.Generic;
using System.Linq;

public class Revrot 
{
    public static string RevRot(string str, int sz)
    {
        if(sz <= 0 || str.Equals("") || sz > str.Length) return "";
        string[] arr = Split(str, sz).ToArray();
        for (int i = 0; i < arr.Length; i++)
        {
            int output = 0;
            if(arr[i].Length == sz)
            {
                foreach (char c in arr[i])
                {
                  int square = int.Parse(c.ToString());
                  output += (square * square * square);
                }
                if(output % 2 == 0)
                {
                    char[] array = arr[i].ToCharArray();
                    Array.Reverse(array);
                    arr[i] = new string(array);
                }
                else
                {
                    arr[i] = arr[i].Substring(1, sz - 1) + arr[i].Substring(0,1);
                }
            }
        }
        return String.Join("",arr);
    }
    
    static IEnumerable<string> Split(string str, int chunkSize)
    {
        return Enumerable.Range(0, str.Length / chunkSize)
            .Select(i => str.Substring(i * chunkSize, chunkSize));
    }
}