using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{    
    public int DistinctDigitYear(int year)
    {   
        if(year < 1000 || year > 9000) return 0;
        do
        {
            year++;
            if(GetIntArray(year).Distinct().Count() == 4) return year;
        }while(year < 9000); 
        return 0;
    }
    
    public static int[] GetIntArray(int num)
    {
        List<int> listOfInts = new List<int>();
        while(num > 0)
        {
            listOfInts.Add(num % 10);
            num /= 10;
        }
        listOfInts.Reverse();
        return listOfInts.ToArray();
    }
}