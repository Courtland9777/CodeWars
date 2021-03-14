using System;
public class Kata
{
  public static bool Alphanumeric(string str)
  {
      if(String.IsNullOrWhiteSpace(str)) return false;
      char[] arr = str.ToCharArray();
      for(int i = 0; i < arr.Length; i++)
      {
          if(!Char.IsLetterOrDigit(arr[i])) return false;
      }
      return true;
  }
}