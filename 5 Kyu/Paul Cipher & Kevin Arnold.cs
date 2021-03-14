using System;
namespace Kata
{
  public class PaulCipher
  {
    public static string Encode(string input)
    {
        if(String.IsNullOrWhiteSpace(input)) return "";
        string encStr = "";
        int key = 0;
        char lastChar; 
        foreach(char ch in input.ToUpper())
        {
            lastChar = ch;
            
            encStr += Cipher(ch , key);
            int tk = GetNewKey(ch);
            key = (tk != -1) ? tk : key;
        }        
        return encStr;
    }
    
    public static string Decode(string input)
    {
        if(String.IsNullOrWhiteSpace(input)) return "";
        
        int key = 0;
        char lastChar;
        
        int n = 1;
        int counter;
        do
        {        
            counter = n * 26;
            n++;
            
        } while(counter < input.Length);
        
        string dycStr = string.Empty;
        foreach (char ch in input.ToUpper())
        {
            lastChar = ch;
            char decChar = Cipher(ch, counter - key);
            dycStr += decChar;
            int tk = GetNewKey(decChar);
            key = (tk != -1) ? tk : key;   
        }
        return dycStr;
    }  
    
    private static char Cipher(char ch, int key)
    {
        if (!char.IsLetter(ch))
        {
            return ch;
        }
  
        char d = 'A';
        return (char)((((ch + key) - d) % 26) + d);
    }
    
    private static int GetNewKey(char ch)
    {
        if (!char.IsLetter(ch))
        {
            return -1;
        }
        char d = 'A';
        return ((ch - d) % 26) + 1;
    }
  }
}