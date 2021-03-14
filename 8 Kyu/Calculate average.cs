using System.Linq;
class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    return array.Length > 0 ? array.Average() : 0;
  }
} 