using System.Linq;
public class Kata
{
  public static int LargestPairSum(int[] numbers) =>
    numbers.OrderByDescending(n => n).Take(2).Sum();
}