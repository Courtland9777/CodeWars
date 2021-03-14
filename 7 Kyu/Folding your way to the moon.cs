public class Kata
{
  public static int? FoldTo(double distance)
  {
    if (distance < 0) return null;
    if (distance == 0) return 0;
    double paper = 0.0001;
    int count = 0;
    while (paper < distance)
    {
        paper *= 2;
        count++;
    };

    return count;
  }
}