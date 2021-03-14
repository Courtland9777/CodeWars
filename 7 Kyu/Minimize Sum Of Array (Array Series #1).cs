using System.Linq;
class Kata
{
    public static int MinSum(int[] a)
    {
        int result = 0;
        var arr = a.OrderBy(n => n).ToArray();
        int j = a.Length - 1;
        for (int i = 0; i < a.Length / 2; i++)
        {
            result += (arr[i] * arr[j]);
            j--;
        }

        return result;
    }
}