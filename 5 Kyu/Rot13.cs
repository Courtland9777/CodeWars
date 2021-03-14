using System;

public class Kata
{
  public static string Rot13(string message)
  {
      string enCode = "";
      var arr = message.ToCharArray();
      for (int i = 0; i < arr.Length; i++)
      {
          enCode += Cipher(arr[i], 13);
      }

      return enCode;
  }

  public static char Cipher(char ch, int key)
  {
      if (!char.IsLetter(ch))
      {
          return ch;
      }

      char d = char.IsUpper(ch) ? 'A' : 'a';
      return (char)((((ch + key) - d) % 26) + d);
  }
}