using System;
using System.Linq;
using System.Text;
public class Digits
{
  public static string Explode(string s)
  {
      var arr = s.Select(x => int.Parse(x.ToString())).ToArray();
      var sb = new StringBuilder();
      foreach (var num in arr)
      {
          for (int i = 0; i < num; i++)
          {
              sb.Append(num.ToString());
          }
      }
      return sb.ToString();
  }
}