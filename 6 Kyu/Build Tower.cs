using System;
using System.Text;

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    int floorLength = nFloors * 2 - 1;
    var arr = new string[nFloors];
    StringBuilder sb = new StringBuilder();
    for (int i = 1; i <= nFloors; i++)
    {
        sb.Clear();
        sb.Append(' ', nFloors - i);
        sb.Append('*', floorLength - (nFloors - i) * 2);
        sb.Append(' ', nFloors - i);
        arr[i-1] = sb.ToString();
    }

    return arr;
  }
}