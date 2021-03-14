public class Kata
{
  public static string Remove(string s)
  {
      int removeFromEnd = 0;
      for (int i = s.Length - 1; i >= 0; i--)
      {
          if (char.IsPunctuation(s[i]))
          {
              removeFromEnd++;
          }
          else
          {
              string begin = s.Substring(0, s.Length - removeFromEnd);
              string end = s.Substring(s.Length - removeFromEnd, removeFromEnd);
              return $"{begin.Replace("!", "")}{end}";
          }
      }
      return s;
  }
}