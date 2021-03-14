using System;
using System.Linq;

public class IQ
{
    public static int Test(string numbers)
    { 
        if(numbers.Equals("")) return 0;
        string[] strArr = numbers.Split(' ').ToArray();
        int[] arr = Array.ConvertAll(strArr,Int32.Parse);
        
        int evenCounter = 0;
        for (int i = 0; i < 3; i++)
        {
            if(arr[i] % 2 == 0) evenCounter++;
        }
        
        bool lookingForEven = (evenCounter < 2);
        for (int i = 0; i < arr.Length; i++)
        {
            if(lookingForEven)
            {
                if(arr[i] % 2 == 0) return i + 1;
            }
            else if(!lookingForEven)
            {
                if (arr[i] % 2 != 0) return i + 1;
            }
        }
        return 0;
    }
}