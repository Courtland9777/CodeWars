using System.Linq;
public class Kata
{
  public short nextHappyYear(short year)
  {
    bool hy;
    do
    {
        year += 1;
        hy = year.ToString().ToCharArray().Distinct().Count() == 4;
    } while (!hy);
    return year;
  }
}