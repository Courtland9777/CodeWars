public class Kata
{
  public static string Remove(string s)
  {
    var arr = s.ToCharArray();
    return arr[arr.Length - 1].Equals('!') ? s.Substring(0, s.Length - 1) : s;
  }
}