using System;
using System.Text;
public class HQ9
{
  public static string Interpret(string code)
  {
      return code == "H" ? "Hello World!" : code == "Q" ? code : code == "9" ? BottlesOfBeer() : null;
  }

  private static string BottlesOfBeer()
  {
      var sb = new StringBuilder();
      for (int n = 99; n > 2; n--)
      {
          sb.AppendFormat("{0} bottles of beer on the wall, {0} bottles of beer.", n).AppendLine();
          sb.AppendFormat("Take one down and pass it around, {0} bottles of beer on the wall.",n - 1).AppendLine();
      }

      sb.AppendLine("2 bottles of beer on the wall, 2 bottles of beer.");
      sb.AppendLine("Take one down and pass it around, 1 bottle of beer on the wall.");
      sb.AppendLine("1 bottle of beer on the wall, 1 bottle of beer.");
      sb.AppendLine("Take one down and pass it around, no more bottles of beer on the wall.");
      sb.AppendLine("No more bottles of beer on the wall, no more bottles of beer.");
      sb.Append("Go to the store and buy some more, 99 bottles of beer on the wall.");
      return sb.ToString();
  }
}