public class Kata
{
  public static string Apple(object n)
  {
    return int.Parse(n.ToString()) * int.Parse(n.ToString()) > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
  }
}