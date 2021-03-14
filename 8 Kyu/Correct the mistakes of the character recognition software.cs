using System;

public class Kata
{
  public static string Correct(string text)
  {
    char[] arr = text.ToCharArray();
    for (int i = 0; i < arr.Length; i++)
    {
        switch (arr[i])
        {
            case '5': arr[i] = 'S';
                break;
            case '0':
                arr[i] = 'O';
                break;
            case '1':
                arr[i] = 'I';
                break;
            default:
                break;
        }
    }
    return String.Join("", arr);
  }
}