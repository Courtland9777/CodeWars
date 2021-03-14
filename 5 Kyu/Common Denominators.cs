using System;

public class Fracts
{
  public static string convertFrac(long[,] arr)
  {
    if(arr == null) return "";
    if(arr.Length == 0) return "";
    
    long tempLCD = arr[0, 1];
    
    for (int i = 1; i < arr.Length/2; i++)
    {
        tempLCD = Lcm(tempLCD, arr[i, 1]);
    }
    
    long lcd = tempLCD;
    string result = "";
    
    for (int i = 0; i < arr.Length/2; i++)
    {
        long num = arr[i, 0];
        num *= (lcd / arr[i, 1]);
        result += "(" + num + "," + lcd + ")";
    }
    return result;
  }
  
  static long Lcm(long a, long b)
  {
    return (a * b) / Gcd(a, b);
  }
  
  static long Gcd(long a, long b)
  {
    if (a == 0) return b;
  
    return Gcd(b % a, a);
  }
}