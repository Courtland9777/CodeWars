using System.Linq;
public class Kata
{
  public static string RakeGarden(string garden) =>
    string.Join(" ",garden.Split(" ").Select(x => x.Equals("rock") || x.Equals("gravel") ? x : "gravel"));
}