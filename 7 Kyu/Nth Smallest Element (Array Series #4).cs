using System.Linq;
class Kata
{
    public static int NthSmallest(int[] arr, int pos) =>
      arr.OrderBy(n => n).Skip(pos - 1).First();
}