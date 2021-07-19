using System.Linq;
class Kata
{
    public static string StrongNumber(int number) =>
        number == number.ToString().ToCharArray().Select(
          x => int.Parse(x.ToString())).ToArray().Sum(n=> Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item))
          ? "STRONG!!!!" : "Not Strong !!";
}