using System;

public static class Kata
{
  public static string Order(string words)
  {
    if (words == "") { return ""; }
    string returnString = "";
    string tempString = "";
    
    
    string[] arr = words.Split(' ');
    for (int i = 1; i <= arr.Length; i++)
    {
      int n = 0;
      tempString = "";
      do
      {
        if (arr[n].Contains(i.ToString()))
        {
          tempString = arr[n];
        }
        n++;
      } while (tempString == "" || n < arr.Length - 1);
      if (returnString == "") { returnString = tempString;}
      else
      {
        returnString = returnString + " " + tempString;
      }
    }
    return returnString;
    throw new NotImplementedException();
  }
}