using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static long QueueTime(int[] customers, int n)
    {
        if(customers.Length == 0 || n == 0) return 0;
        var que = new Queue<int>();
        for (int i = 0; i < customers.Length; i++)
        {
            que.Enqueue(customers[i]);
        }
        int[] arr = new int[n];
        long minCounter = 0;
        do
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0 && que.Count != 0)
                {
                    arr[i] = que.Dequeue();
                }
            }
            
            for (int j = 0; j < arr.Length; j++)
            {
                if(arr[j] != 0) arr[j]--;
            }
            minCounter++;
        }while(arr.Sum() > 0 || que.Count > 0);
        return minCounter;
    }
}