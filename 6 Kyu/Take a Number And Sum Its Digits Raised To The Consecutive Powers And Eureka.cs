using System;
using System.Collections.Generic;
using System.Linq;

public class SumDigPower {
    
    public static long[] SumDigPow(long a, long b) 
    {
        long[] arr;
        List<long> list = new List<long>();
        for (long i = a; i <= b; i++)
        {
            arr = i.ToString().Select(digit => long.Parse(digit.ToString())).ToArray(); 
        
            long tempSum = 0;
            for (int j = 0; j < arr.Length ; j++)
            {
                tempSum += (long)Math.Pow(arr[j],j+1);
            }
            if(tempSum == i)
            {
                list.Add(tempSum);
            }
        }
        return list.ToArray();
    }
}