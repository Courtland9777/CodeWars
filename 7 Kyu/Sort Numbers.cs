using System.Linq;
public class Kata
{
  public static int[] SortNumbers(int[] nums)
  {
    return nums is null ? new int[0] : nums.OrderBy(x=>x).ToArray();
  }
}