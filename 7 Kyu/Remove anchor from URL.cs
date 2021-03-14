using System.Linq;

public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
    return url.Contains('#') ? url.Substring(0, url.IndexOf('#')) : url;
  }
}