using System;
using System.Text;

public class RepeatIt
{
  public static string RepeatString(object toRepeat, int n)
  {
      if (toRepeat == null) return "Not a string";
      if (toRepeat.GetType() != typeof(string)) return "Not a string";
      var sb = new StringBuilder();
      for (int i = 0; i < n; i++)
      {
          sb.Append(toRepeat);
      }
      return sb.ToString();
  }
}