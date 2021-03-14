using System;

public class Kata {
  public static int[][] Pyramid(int n) 
  {
    if(n == 0) return new int[0][];
    int[][] arr = new int[n][];
    
        for(int i = 0; i < n; i++)
        {
            arr[i] = new int[i + 1];
            for(int j = 0; j <= i; j++)
            {
                arr[i][j] = 1;
            
            }
        }       
    return arr;
  }
}