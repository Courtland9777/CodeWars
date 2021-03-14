using System;
public class Kata
{
  public static string AbbrevName(string name)
  {
    string[] arr = name.Split(' ');
    arr[0] = arr[0].Substring(0,1).ToUpper();
    arr[1] = arr[1].Substring(0,1).ToUpper();
    return String.Join(".",arr);
  }
}