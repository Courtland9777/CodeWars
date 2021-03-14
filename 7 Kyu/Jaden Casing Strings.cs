using System;
using System.Globalization;

public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    TextInfo ti = new CultureInfo("en-US", false).TextInfo;
    return ti.ToTitleCase(phrase.ToLower());
  }
}