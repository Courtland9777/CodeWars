using System;
using System.Collections.Generic;

public class HumanTimeFormat{
  public static string formatDuration(int seconds)
  {
      if (seconds == 0) return "now";
      int remainder = seconds;
      var list = new List<string>();
      if (seconds >= 31536000)
      {
          list.Add(GetYears(seconds));
          remainder = seconds % 31536000;
      }

      if (remainder >= 86400)
      {
          list.Add(GetDays(remainder));
          remainder %= 86400;
      }

      if (remainder >= 3600)
      {
          list.Add(GetHour(remainder));
          remainder %= 3600;
      }

      if (remainder >= 60)
      {
          list.Add(GetMin(remainder));
          remainder %= 60;
      }

      if (remainder < 60 && remainder > 0)
      {
          list.Add(GetSec(remainder));
      }

      if (list.Count == 1)
      {
          return list[0];
      }

      if (list.Count == 2)
      {
          return $"{list[0]} and {list[1]}";
      }

      string str = $"{list[list.Count-2]} and {list[list.Count - 1]}";
      list.RemoveRange(list.Count - 2,2);
      return $"{string.Join(", ", list)}, {str}";

  }

  public static string GetYears(int seconds)
  {
      return seconds / 31536000 < 2 ? "1 year" : $"{seconds / 31536000} years";
  }

  public static string GetDays(int seconds)
  {
      return seconds / 86400 < 2 ? "1 day" : $"{seconds / 86400} days";
  }

  public static string GetHour(int seconds)
  {
      return seconds / 3600 < 2 ? "1 hour" : $"{seconds / 3600} hours";
  }

  public static string GetMin(int seconds)
  {
      return seconds / 60 < 2 ? "1 minute" : $"{seconds / 60} minutes";
  }

  public static string GetSec(int seconds)
  {
      return seconds == 1 ? "1 second" : $"{seconds} seconds";
  }
}