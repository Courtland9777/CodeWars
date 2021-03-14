using System;
using System.Linq;

public class MaxDiffLength 
{
    
    public static int Mxdiflg(string[] a1, string[] a2) 
    {
        if(a1 == null || a2 == null)
        {
            return -1;
        }
        if(a1.Length == 0 || a2.Length == 0)
        {
            return -1;
        }
        
        string longest = a2.OrderByDescending( s => s.Length ).First();
        string shortest = a1.OrderBy( s => s.Length ).First();
        int test1 = Math.Abs(longest.Length - shortest.Length);
        
        string longest1 = a1.OrderByDescending( s => s.Length ).First();
        string shortest1 = a2.OrderBy( s => s.Length ).First();
        int test2 = Math.Abs(longest1.Length - shortest1.Length);
        
        if(test2 > test1)
        {
            return test2;
        }
        else
        {
            return test1;
        }
    }
}