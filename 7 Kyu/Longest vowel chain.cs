using System;

public static class Kata
{
  public static int Solve(string str)
  {
  Console.WriteLine(str);
      if(str == null) throw new ArgumentNullException();
      int count = 0, max = 0;
      for (int i = 0; i < str.Length; i++)
      {
          if ("aeiou".Contains(str[i]))
          {
              count++;
              if (max < count) max = count;
          }
          else
          {
              if (max < count) max = count;
              count = 0;
          }
      }
      return max;
  }
}