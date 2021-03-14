using System.Linq;
public class Kata
{
  public static int[] FilterLucky(int[] x) => x.Where(n => n.ToString().Contains('7')).ToArray();  
}