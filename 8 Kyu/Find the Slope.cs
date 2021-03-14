using System;
public class Slope
{
  public String slope(int[] p) => p[2] - p[0] == 0 ? "undefined" : ((p[3] - p[1]) / (p[2] - p[0])).ToString();
}