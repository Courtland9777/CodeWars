using System;
using System.Linq;
public class Kata
{   
  public static string NameShuffler(string str)
  {
   return string.Join(" ", str.Split(' ').Reverse());
  }
}