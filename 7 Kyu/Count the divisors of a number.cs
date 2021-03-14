using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static int Divisors(int number)
  {
      List<int> factors = new List<int>();
      int max = (int)Math.Sqrt(number);
      for (int factor = 1; factor <= max; ++factor)
      { 
          if (number % factor == 0)
          {
              factors.Add(factor);
              if (factor != number / factor)
              { 
                  factors.Add(number / factor);
              }
          }
      }
      return factors.Distinct().Count();
  }
}