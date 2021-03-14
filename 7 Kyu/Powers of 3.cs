using System;
public class Kata
{
  public static int LargestPower(int n)
  {
    if(n==1) return -1;
    int counter = 0;
    for (int i = 1; i < 100; i++)
    {
        if((Math.Pow(3,i)) >= n) return counter;
        counter++;
    }
    return 0;
  }
}