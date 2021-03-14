namespace Main{

using System;
using System.Linq;
public class Kata
{
  public static int[] DataReverse(int[] data)
  {
      int startStr = data.Length - 8;
      string str = "";
      string dataStr = string.Join("", data.Select(x => x.ToString()));
      Console.WriteLine(dataStr.Length);
      while(startStr >= 0)
      {
          string temp = dataStr.Substring(startStr, 8);
          str += temp;
          startStr -= 8;
      }

      return str.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
    }
  }
}