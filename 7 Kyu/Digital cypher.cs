using System.Linq;
using System;

public  class Kata
{
    public static int[] Encode(string str, int n)
    {
        var arrStr = str.ToCharArray();
        var arrKey = n.ToString().ToCharArray();
        var result = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            int check = i % arrKey.Length;
            result[i] = (arrStr[i] - '`') + (arrKey[i % arrKey.Length] - '0');
        }
        return result;
    }
}