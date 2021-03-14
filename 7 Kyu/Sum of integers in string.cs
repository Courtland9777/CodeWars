using System;
using System.Linq;
public class Kata
{
  public static int SumOfIntegersInString(string s) =>
    string.Concat(s.Select(c => char.IsNumber(c) ? c.ToString() : c.ToString().Replace(c.ToString(), " ")))
      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Sum(int.Parse);
}