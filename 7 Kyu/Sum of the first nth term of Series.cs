using System;

public class NthSeries {
  
  public static string seriesSum (int n) {
    if (n == 0 || n == 1) return $"{n:0.00}";
    double sum = 1.00;
    int p = 1;
    for (int i = 1; i < n; i++)
    {
        p += 3;
        sum += (1d / p);
    }

    return $"{sum:0.00}";
  }
}