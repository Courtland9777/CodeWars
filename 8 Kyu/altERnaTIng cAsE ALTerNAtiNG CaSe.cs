using System;
using System.Linq;

namespace Extensions
{
  public static class StringExt
  {
    public static string ToAlternatingCase (this string s)
    {
      return new string(
                s.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ?
                    char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
    }
  }
}