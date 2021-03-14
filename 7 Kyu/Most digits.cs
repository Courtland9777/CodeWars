using System.Linq;
public class Kata
{
  public static int FindLongest(int[] number)
  {
    int maxLen = 0;
    string str = "";
    var arr = (string.Join(",",number)).Split(',');
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > maxLen)
        {
            maxLen = arr[i].Length;
            str = arr[i];
        }
    }

    return int.Parse(str);
  }
}