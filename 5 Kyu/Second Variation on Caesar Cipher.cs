using System;
using System.Collections.Generic;
using System.Linq;
public class CaesarTwo
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
  
  public static IEnumerable<string> encodeStr(string input, int key)
  {
    string output = string.Empty;
  
    foreach (char ch in input)
    {
        if(String.IsNullOrEmpty(output))
        {
            output = ch.ToString().ToLower() + cipher(ch, key).ToString().ToLower();
        }
        output += cipher(ch, key);
    } 
    return DivideString(output);
  }
  
  public static string decode(IEnumerable<string> listInput)
  {
    string input = String.Join("", listInput);
   
    int n = 0;
    char ch1 = ' ';
    int key = 0;
    string output = string.Empty;
    foreach (char ch in input)
    {
        if(n == 0)
        {
            ch1 = ch;
        }
        else if(n == 1)
        {
            key = ch - ch1;
            Console.WriteLine(key);
        }
        else
        {
            output += cipher(ch, 26 - key);
        }
        n++;
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
}