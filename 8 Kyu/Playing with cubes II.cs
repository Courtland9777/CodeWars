using System;
public class Cube
{
  private int Side;
  
  public Cube(int side = 0)
  {
      Side = (int) Math.Abs(side);
  }
  
  public int GetSide()
  {
    return this.Side;
  }
  
  public void SetSide(int s)
  {
    this.Side = (int) Math.Abs(s);
  }
}