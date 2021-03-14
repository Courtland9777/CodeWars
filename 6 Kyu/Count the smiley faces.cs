using System;
public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
    int counter = 0;
    foreach (var t in smileys)
    {
        var arr = t.ToCharArray();
        if((arr[0] != ':' && arr[0] != ';') || arr.Length > 3) continue;
        switch (arr.Length)
        {
            case 1: continue;
            case 2 when (arr[1] != ')' && arr[1] != 'D'):
            case 3 when arr[1] != '-' && arr[1] != '~' || (arr[2] != ')' && arr[2] != 'D'):
                continue;
            default:
                counter++;
                break;
        }
    }
    return counter;
  }
}