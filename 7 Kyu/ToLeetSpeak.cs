using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  private static Dictionary<char, char> LeetDictionary()
  {
      return new Dictionary<char, char>
      {
          {'A', '@'},
          {'B', '8'},
          {'C', '('},
          {'D', 'D'},
          {'E', '3'},
          {'F', 'F'},
          {'G', '6'},
          {'H', '#'},
          {'I', '!'},
          {'J', 'J'},
          {'K', 'K'},
          {'L', '1'},
          {'M', 'M'},
          {'N', 'N'},
          {'O', '0'},
          {'P', 'P'},
          {'Q', 'Q'},
          {'R', 'R'},
          {'S', '$'},
          {'T', '7'},
          {'U', 'U'},
          {'V', 'V'},
          {'W', 'W'},
          {'X', 'X'},
          {'Y', 'Y'},
          {'Z', '2'},
          {' ', ' '}
      };
  }

  public static string ToLeetSpeak(string str)
  {
      var dict = LeetDictionary();
      return string.Concat(str.ToUpper().ToCharArray().Select(x => dict[x]));
  }
}