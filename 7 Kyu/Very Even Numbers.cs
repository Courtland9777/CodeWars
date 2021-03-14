using System;
using System.Linq;
public class Kata
{
  public static bool IsVeryEvenNumber(int number) 
  {
    if (number < 10)
    {
        return number % 2 == 0;
    }
    var sumOfDigits = number.ToString().ToCharArray().Sum(x => int.Parse(x.ToString()));
    while (sumOfDigits>9)
    {
        sumOfDigits = sumOfDigits.ToString().ToCharArray().Sum(x => int.Parse(x.ToString()));
    }
    return sumOfDigits % 2 == 0;
  }
}