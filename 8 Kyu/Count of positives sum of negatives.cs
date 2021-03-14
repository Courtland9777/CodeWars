using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input == null || input.Length == 0) return Array.Empty<int>();
        int pos = 0, neg = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 0) continue;
            if ( input[i] > 0) pos++;
            else if (input[i] < 0) neg += input[i];
        }
        return new int[] {pos,neg};
    }
}