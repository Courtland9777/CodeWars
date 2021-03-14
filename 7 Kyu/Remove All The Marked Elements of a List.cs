using System.Linq;
public class Kata
{
  public static int[] Remove(int[] integerList, int[] valuesList) =>
    integerList.Where(x => !valuesList.Contains(x)).ToArray();
}