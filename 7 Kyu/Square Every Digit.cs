using System;
using System.Linq;

public class Kata
{
  public static int SquareDigits(int n)
  {
    var intList = n.ToString().Select(digit => int.Parse(digit.ToString()));
    string result = "";
    foreach(var item in intList)
    {        
        result += (item * item).ToString();
        Console.WriteLine(result);
    }
    return int.Parse(result);
  }
}