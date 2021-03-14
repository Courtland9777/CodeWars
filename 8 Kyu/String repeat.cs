using System.Text;
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      if (s.Length == 1)
      {
          var sb = new StringBuilder();
          var arr = s.ToCharArray();
          sb.Append(arr[0], n);
          return sb.ToString();
      }

      string repStr = "";
      for (int i = 0; i < n; i++)
      {
          repStr += s;
      }

      return repStr;
    }
  }
}