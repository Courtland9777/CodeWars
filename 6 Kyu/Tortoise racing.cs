public class Tortoise
{
  public static int[] Race(int v1, int v2, int g) 
  {
    if (v2 <= v1) return null;
    var t = (int)(((v2 * (double)g) / (v2 - v1) / v2)*3600);
    return new int[] { t/3600, (t/60)%60, t%60 };
  }
}