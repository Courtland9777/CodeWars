using System;
public class Kata
{
  public static long FindNextSquare(long num)
  {
    double result = Math.Sqrt(num);
    if(result % 1 != 0) return -1;
    long nextN = (long)Math.Floor(Math.Sqrt(num)) + 1; 
  
    return nextN * nextN; 
  }
}