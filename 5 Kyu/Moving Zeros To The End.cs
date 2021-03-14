using System;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
        int n = arr.Length;
        int count = 0;  
          
        for (int i = 0; i < n; i++) 
        if (arr[i] != 0) 
          
        arr[count++] = arr[i];  
           
        while (count < n) 
        arr[count++] = 0; 
        return arr;    
  }
}