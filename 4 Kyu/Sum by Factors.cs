using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfDivided {
  
  public static string sumOfDivided(int[] lst)
  {
      if (lst.Length == 0) return "";
      var pfList = PrimeFactors(lst);
      string str = "";

      foreach (var item in pfList)
      {
          int sum = 0;
          bool flag = false;
          for (int i = 0; i < lst.Length; i++)
          {
              if (lst[i] % item == 0)
              {
                  flag = true;
                  sum += lst[i];
              }
          }

          if (flag) str += $"({item} {sum})";
      }

      return str;
  }

  public static IEnumerable<int> PrimeFactors(int[] arr)
  {
      var list = new List<int>();

      for (int p = 0; p < arr.Length; p++)
      {
          int n = Math.Abs(arr[p]);

          while (n % 2 == 0)
          {
              list.Add(2);
              n /= 2;
          }

          for (int i = 3; i <= Math.Sqrt(n); i += 2)
          {
              while (n % i == 0)
              {
                  list.Add(i);
                  n /= i;
              }
          }

          if (n > 2)
              list.Add(n);
      }

      return list.Distinct().OrderBy(x => x).ToList();
  }
}