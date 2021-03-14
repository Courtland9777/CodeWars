using System;
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    Console.WriteLine(text);
      char[] arr = text.ToCharArray();   
      string str = "";
      for (int i = 0; i < arr.Length; i++)
      {
          string temp = Cipher(arr[i]);
          if(i == 0)
          {
              str += temp.Equals("!") ? "" : temp.ToUpper();
          }
          else if(str.Equals(""))
          {
              str += temp.Equals("!") ? "" : temp;
          }
          else
          {
              str += temp.Equals("!") ? "" : " " + temp;
          }
      }
      return str;
  }
  
  public static string Cipher(char ch)
  {
      if (!char.IsLetter(ch))
      {
          return "!";
      }
      int key = 1;
      char d = char.IsUpper(ch) ? 'A' : 'a';
      int temp = (((ch + key) - d) % 26);
      if(temp == 0) temp = 26;
      return temp.ToString();
  }
}