using System;
using System.Linq;
public class Kata
{
  public static int FindDigit(int num, int nth)
  {
      if(nth < 1) return -1;
      if(num == 0) return 0;
      return Math.Abs(num).ToString().Length >= nth ? int.Parse(num.ToString().ToCharArray().Reverse().ElementAt(nth-1).ToString()) : 0;
  }
}