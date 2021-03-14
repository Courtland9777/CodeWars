using System;
public class ProperFractionsSolution
{
    public static long ProperFractions(long n) 
    { 
      if(n == 1) return 0;
      long result = n;  
        
      for (int p = 2; 
               p * p <= n; ++p) 
      { 
          if (n % p == 0)  
          { 
              while (n % p == 0) 
                  n /= p; 
              result -= result / p; 
          } 
      } 
        
      if (n > 1) 
          result -= result / n; 
      return result; 
    } 
}