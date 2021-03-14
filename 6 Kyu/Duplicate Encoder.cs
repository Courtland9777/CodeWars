using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
      var arr = word.ToLower().ToCharArray();
      var dict = new Dictionary<char, int>();
      foreach (var letter in arr.GroupBy(x => x)
                                .Select(group => new {
                                     Letter = group.Key,
                                     Count = group.Count()
                                 }))
      {
          Console.WriteLine($"Key = {letter.Letter} Value = {letter.Count}");
          dict.Add(letter.Letter, letter.Count);
      }

      string str = "";
      for (int i = 0; i < arr.Length; i++)
      {
          if (dict[arr[i]] == 1) str += "(";
          else str += ")";
      }
      return str;
  }
}