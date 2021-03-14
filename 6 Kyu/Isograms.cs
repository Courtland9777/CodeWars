using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    if (str == ""){return true;}
    
    str = str.ToLower();
    int len = str.Length;
    
    char[] arr = str.ToCharArray();
    
    Array.Sort(arr);
    
    for (int i = 0; i < len - 1; i++){
      if (arr[i] == arr[i + 1])
        return false;
    }
    return true;
  }
}