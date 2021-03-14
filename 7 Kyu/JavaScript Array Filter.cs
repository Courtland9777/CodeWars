using System.Linq;

public class Kata
{
  public static int[] GetEvenNumbers(int[] numbers) => numbers.Where(x => x % 2 == 0).ToArray();
}