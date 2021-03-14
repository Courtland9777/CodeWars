public class Kata
{
  public static string DoubleChar(string s)
  {
    char[] arr = s.ToCharArray();
    string retStr = "";
    for (int i = 0; i < arr.Length; i++)
    {
        retStr += arr[i].ToString() + arr[i].ToString();
    }
    return retStr;
  }
}