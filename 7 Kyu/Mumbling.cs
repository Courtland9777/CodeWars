using System;
using System.Text.RegularExpressions;

public class Accumul 
{
  public static string Accum(string s) 
  {
      string[] arr = Regex.Split(s, string.Empty);
      string letter = "";
      
      for (int i = 0; i < arr.Length; i++)
      {
          arr[i] = arr[i].ToUpper();
          letter = arr[i].ToLower();
          for(int j = i; j > 1; j--)
          {
              arr[i] += letter;
          }
      }
      string temp = String.Join("-", arr);
      temp = temp.Substring(1, temp.Length-2);
      
      return temp;
  }
}