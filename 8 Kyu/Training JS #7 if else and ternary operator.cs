public class Kata
{
  public static int SaleHotDogs(int n)
  {
    return n >= 10 ? 90*n : n < 5 ? 100*n : 95*n;
  }
}