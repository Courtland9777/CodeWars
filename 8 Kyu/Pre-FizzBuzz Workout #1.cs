using System.Linq;
public class Kata
{
  public static int[] PreFizz(int n) 
  {
    return Enumerable.Range(1,n).ToArray();
  }
}