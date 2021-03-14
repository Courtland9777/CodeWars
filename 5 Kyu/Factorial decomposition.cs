using System;
using System.Linq;
using System.Collections.Generic;

class FactDecomp
{
    public static string Decomp(int i)
    {
        string result = "";
        
        var factors = new List<int>();
        for(int q = i; q > 1; q--)
        {
            int n = q;
            for (var divisor = 2; n > 1; divisor++)
                for (; n % divisor == 0; n /= divisor)
                    factors.Add(divisor);
        }
        
        factors.Sort();
        
        var numberGroups = factors.GroupBy(p => p);
        foreach(var grp in numberGroups)
        {
            var number = grp.Key;
            var total  = grp.Count();
            
            result += total > 1 ? number + "^" + total + " * " : number + " * ";
        }

        if(result.Length > 3)
        {
            result = result.Remove(result.Length - 3);
        }
        return result;
    }
}