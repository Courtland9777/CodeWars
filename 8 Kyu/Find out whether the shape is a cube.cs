namespace CubeCheck {
  using System;
  public class CubeChecker
  {
    public bool IsCube(double volume, double side)
    {
      return !(volume < 1) && !(side < 1) && (int)volume == (int)Math.Pow(side, 3);
    }
  }
}