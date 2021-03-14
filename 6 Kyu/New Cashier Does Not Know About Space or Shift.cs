using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
public static class Kata
{
  public static string GetOrder(string input)
  {
      var list = new List<string>
      {
          {"Burger"}, {"Fries"},
          {"Chicken"}, {"Pizza"},
          {"Sandwich"}, {"Onionrings"},
          {"Milkshake"}, {"Coke"}
      };
      var sb = new StringBuilder();
      foreach (var item in list)
      {
          var strCount = Regex.Matches(input, item.ToLower()).Count;
          for (int i = 0; i < strCount; i++)
          {
              sb.Append(' ').Append(item);
          }
      }

      return sb.ToString().Substring(1);
  }
}