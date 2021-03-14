using System;

public class Cube
{
    private int side;
    private int surface;
    private int volume;
    public Cube(int s = 0)
    {
        side = Math.Abs(s);
        volume = side * side * side;
        surface = side * side * 6;
    }

    public int Side
    {
        get => side;
        set => side = Math.Abs(value);
    }

    public int Surface => side * side * 6;

    public int Volume => side * side * side;
}