using System.Linq;
public class Kata
{
    public static int AdjacentElementsProduct(int[] array)
    {
      return array.Skip(1).Zip(array, (second, first) => second*first).Max();
    }
}