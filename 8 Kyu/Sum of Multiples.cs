using System;
public class Kata
{
  public static int SumMul(int n, int m)
  {
    if (m <= 0 || n <= 0 || n >= m) throw new ArgumentException("error!");
    int b = 1;
    int result = 0;
    while (b*n <= m)
    {
        result += b*n;
        b++;
    }
    return result;
  }
}