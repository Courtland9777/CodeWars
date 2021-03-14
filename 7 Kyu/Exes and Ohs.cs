using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    char[] arr = input.ToCharArray();
    return (arr.Where(x => x.Equals('x') || x.Equals('X')).Count() - arr.Where(x => x.Equals('o') || x.Equals('O')).Count()) == 0;  
  }
}