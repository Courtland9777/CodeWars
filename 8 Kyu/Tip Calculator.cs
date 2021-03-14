using System;
using System.Collections.Generic;
public class Kata
{
  public static int CalculateTip(double amount, string rating)
  {
    var dict = new Dictionary<string,double>(StringComparer.OrdinalIgnoreCase)
    {
        {"Terrible", 0},
        {"Poor", .05},
        {"Good", .1 },
        {"Great",.15 },
        {"Excellent", .2 }
    };

    return dict.ContainsKey(rating) ? (int)Math.Ceiling(amount * dict[rating]) : -1;
  }
}