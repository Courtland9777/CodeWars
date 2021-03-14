using System;
public class Dinglemouse
{
    public static string MakePassword(int len, bool flagUpper, bool flagLower, bool flagDigit)
    {
    string returnStr = "";
    int digitCounter = 1;
    if(!flagUpper && !flagLower && !flagDigit) return "";
    else if(!flagUpper && !flagLower)
    {
        for (int i = 0; i < len; i++)
        {
            returnStr += i;
        }
        return returnStr;
    }
    else if(!flagUpper && !flagDigit)
    {
        for (int i = 0; i < len; i++)
        {
            returnStr += Cipher('a',i);
        }
        return returnStr;
    }
    else if(!flagLower && !flagDigit)
    {
        for (int i = 0; i < len; i++)
        {
            returnStr += Cipher('A',i);
        }
        return returnStr;
    }
    else if(flagUpper && flagLower && flagDigit)
    {
        returnStr = "Z0";
        for (int i = 0; i < len -2; i++)
        {
            if(i < 26) returnStr += Cipher('a',i);
            else if(i < 51) returnStr += Cipher('A',i);
            else
            {
                returnStr += digitCounter;
                digitCounter++;
            }
        }
        return returnStr;
    }
    else if(flagUpper && flagLower && !flagDigit)
    {
        returnStr = "Z";
        for (int i = 0; i < len -1; i++)
        {
            if(i < 26) returnStr += Cipher('a',i);
            else
            {
                returnStr += Cipher('A',i);             
            }
        }
        return returnStr;
    }
    else if(!flagUpper && flagLower && flagDigit)
    {
        returnStr = "0";
        for (int i = 0; i < len -1; i++)
        {
            if(i < 26) returnStr += Cipher('a',i);
            else
            {
                returnStr += digitCounter;
                digitCounter++;
            }
        }
        return returnStr;
    }
    else if(flagUpper && !flagLower && flagDigit)
    {
        returnStr = "0";
        for (int i = 0; i < len -1; i++)
        {
            if(i < 26) returnStr += Cipher('A',i);
            else
            {
                returnStr += digitCounter;
                digitCounter++;
            }
        }
        return returnStr;
    }
    return "Password123";
  }
  public static char Cipher(char ch, int key)
  {
      char d = char.IsUpper(ch) ? 'A' : 'a';
      return (char)((((ch + key) - d) % 26) + d);
  }
}