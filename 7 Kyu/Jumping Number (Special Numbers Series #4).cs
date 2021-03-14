using System.Linq;
class Kata
{
    public static string JumpingNumber(int n)
    {
        var arr = n.ToString().Select(x => int.Parse(x.ToString())).ToArray();
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] != arr[i + 1] + 1 && arr[i] != arr[i + 1] - 1) return "Not!!";
        }

        return "Jumping!!";
    }
}