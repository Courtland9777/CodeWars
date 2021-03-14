public class Kata
{
  public static string FakeBin(string x)
  {
    var s = string.Empty;
    foreach (var c in x)
    {
        if (int.Parse(c.ToString()) < 5)
        {
            s += "0";
        }
        else
        {
            s += "1";
        }
    }

    return s;
  }
}