using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetLongestPalindrome(string str)
  {
    if (str == null) return 0;
    if (IsPalindrome(str)) return str.Length;
    var longestPalindrome = 0;
    for (var i = 1; i < str.Length; i++)
    {
        for (var start = 0; start <= str.Length - i; start++)
        {
            var substr = str.Substring(start, i);
            if (!IsPalindrome(substr)) continue;
            longestPalindrome = substr.Length;
        }
    }
    return longestPalindrome;
  }
  
  private static bool IsPalindrome(string input) =>
    input.Equals(string.Concat(input.Reverse()));
}