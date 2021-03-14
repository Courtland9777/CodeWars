using System.Linq;

public class Kata
{
  public static string OddOrEven(int[] array)
  {
    return array.Sum(m => m) % 2 == 0 ? "even" : "odd";
  }
}