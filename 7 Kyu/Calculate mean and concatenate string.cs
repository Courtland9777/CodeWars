using System;
using System.Linq;
public class Kata
{
  public static object[] Mean(char[] lst) =>
    new object[] { lst.Where(char.IsNumber).Sum(x => x - '0')/(10d), string.Concat(lst.Where(char.IsLetter)) };
}