using System;

public class Kata
{
   public static string Encrypt(string text, int n)
    {
        if(text == null)
        {
            return text;
        }
        if(n <= 0 || text == "")
        {
            return text;
        }
        
        
        string encBegin = "";
        string encEnd = "";
        string combinedStr = text;
        int j = 1;
        
        while(j <= n)
        {
            char[] arr = combinedStr.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if(i % 2 != 0)
                {
                    encBegin += arr[i];
                }
                else
                {
                    encEnd += arr[i];
                }
            }
            combinedStr = encBegin + encEnd;
            encBegin = "";
            encEnd = "";
            j++;
        }
        return combinedStr;
    }
    
    public static string Decrypt(string encryptedText, int n)
    {
        if(encryptedText == null)
        {
            return encryptedText;
        }
        if(n <= 0 || encryptedText == "")
        {
            return encryptedText;
        }
        
        int midStr = encryptedText.Length/2;
        string combinedStr = encryptedText;
        int j = 1;
        
        while(j <= n)
        {
            char[] decryBegin = combinedStr.Substring(0,midStr).ToCharArray();
            char[] decryEnd = combinedStr.Substring(midStr).ToCharArray();
            
            int decryLen = decryEnd.Length;
            combinedStr = "";

            for(int i = 0; i < decryBegin.Length; i++)
            {
                combinedStr += $"{decryEnd[i]}{decryBegin[i]}";
            }
                 
            if(decryBegin.Length < decryLen)
            {
                combinedStr += decryEnd[decryLen - 1];
            }
            j++;
        }
        return combinedStr;
    }
}