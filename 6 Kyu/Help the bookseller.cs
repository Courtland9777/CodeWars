using System;
using System.Collections.Generic;
using System.Linq;

public class StockList {

    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter) 
    {
      if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0) return "";
      var dict = new Dictionary<string,int>();
      for (int i = 0; i < lstOf1stLetter.Length; i++)
      {
          dict.Add(lstOf1stLetter[i], 0);
      }
  
      for (int i = 0; i < lstOfArt.Length; i++)
      {
          if (dict.ContainsKey(lstOfArt[i].Substring(0, 1)))
          {
              dict[lstOfArt[i].Substring(0, 1)] += int.Parse(string.Concat(lstOfArt[i].Where(char.IsDigit).ToArray()));
          }
      }
  
      var arr = new string[lstOf1stLetter.Length];
      for (int i = 0; i < lstOf1stLetter.Length; i++)
      {
          arr[i] = $"({lstOf1stLetter[i]} : {dict[lstOf1stLetter[i]]})";
      }
  
      return string.Join(" - ", arr);
    }
}