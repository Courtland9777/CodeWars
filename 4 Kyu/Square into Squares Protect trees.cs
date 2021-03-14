using System;
using System.Collections.Generic;

public class Decompose 
{
    public string decompose(long n) 
    {
        var decompList = Decomposer(n, n * n);
        if (decompList == null) return null;
        
        decompList.Remove(n);
        var result = new List<string>();
        
        foreach (var ele in decompList)
        {
          result.Add(ele.ToString());
        }
        return string.Join(" ", result);
    }
    
    public static List<long> Decomposer(long n, long remain)
    {
        if (remain == 0)
        {
            var r = new List<long>
            {
                n
            };
            return r;
        }

        for (var i = n - 1; i > 0; i--)
        {
            if ((remain - i * i) < 0) continue;
            var r = Decomposer(i, (remain - i * i));
  
            // only get the answer
            if (r == null) continue;
            r.Add(n);
            return r;
        }
        return null;
    }
  }