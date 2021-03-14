using System.Linq;
class Kata
{
    public static string SpecialNumber(int number)
    {
      var str = string.Concat(number.ToString().Where(x => "012345".Contains(x)));
      return string.IsNullOrEmpty(str) ? "NOT!!" : number == int.Parse(str) ? "Special!!" : "NOT!!";
    }
}