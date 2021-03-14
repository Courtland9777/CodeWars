using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text; 

public class CaesarCipher
{
  public static char cipher(char ch, int key)
  {
      if (!char.IsLetter(ch))
      {
          return ch;
      }
  
      char d = char.IsUpper(ch) ? 'A' : 'a';
      return (char)((((ch + key) - d) % 26) + d);
  }
  
  
  public static IEnumerable<string> movingShift(string input, int key)
  {
      string output = string.Empty;
  
      foreach (char ch in input)
          output += cipher(ch, key++);
  
      var q = DivideString(output);
      return q.Count() < 5 ? AddBlankToList(q, q.Count()) : q;
  }
  
  public static string demovingShift(IEnumerable<string> listInput, int key)
  {
      string input = String.Join("", listInput);
     
      int n = 1;
      int counter = 0;
      do
      {        
          counter = n * 26;
          n++;
          
      } while(counter < input.Length);
      
      string output = string.Empty;
      foreach (char ch in input)
      {
          output += cipher(ch, counter - key++);
      }
      return output;
  }
  
  public static IEnumerable<string> DivideString(string output)
  {
      int len = output.Length;
      switch (len)
      {
          case int n when (n % 5 == 0): return ChunksUpto(output, len / 5);
          
          case int n when (n % 5 == 4): return ChunksUpto(output, (len + 1) / 5);
          
          case int n when (n % 5 == 3): return ChunksUpto(output, (len + 2) / 5);
          
          case int n when (n % 5 == 2): return ChunksUpto(output, (len + 3) / 4);
          
          case int n when (n % 5 == 1): return ChunksUpto(output, (len + 4) / 5);
  
          default: return new List<string>();
      }
  }
  
  static IEnumerable<string> ChunksUpto(string str, int maxChunkSize)
  {
      for (int i = 0; i < str.Length; i += maxChunkSize)
          yield return str.Substring(i, Math.Min(maxChunkSize, str.Length - i));
  }
  
  public static IEnumerable<string> AddBlankToList(IEnumerable<string> input, int count)
  {
      //Only needed to pass a test requirement.
      int numberToAdd = 5-count;
      var list = new List<string>();
      foreach(var item in input)
      {
          list.Add(item);
      }
      for(int i = 0; i < numberToAdd; i++)
      {
          list.Add("");
      }
      return list;
  }
}