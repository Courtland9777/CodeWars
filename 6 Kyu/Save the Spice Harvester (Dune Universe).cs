using System;
public class Save
{
    private class Harvester
    {
        private readonly int _x;
        private readonly int _y;

        public Harvester(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public Tuple<int,int> Location()
        {
            return new Tuple<int, int>(_x,_y);
        }
    }

    private class MovingObj
    {
        private readonly int _x;
        private readonly int _y;
        private readonly int _speed;

        public MovingObj(int x, int y, int speed)
        {
            this._x = x;
            this._y = y;
            this._speed = speed;
        }

        public Tuple<int, int> Location()
        {
            return new Tuple<int, int>(_x, _y);
        }

        public int Speed()
        {
            return _speed;
        }
    }

    public static string HarvesterRescue(int[][] data)
    {
        const string success = "The spice must flow! Rescue the harvester!";
        const string fail = "Damn the spice! I'll rescue the miners!";
        var harvester = new Harvester(data[0][0], data[0][1]);
        var worm = new MovingObj(data[1][0], data[1][1], data[1][2]);
        var carryall = new MovingObj(data[2][0], data[2][1], data[2][2]);

        double w2hTime = Time(Distance(harvester.Location(), worm.Location()),worm.Speed());
        double c2hTime = Time(Distance(harvester.Location(), carryall.Location()),carryall.Speed());
        return w2hTime - c2hTime > 1 ? success : fail;
    }

    private static double Distance(Tuple<int, int> cord1, Tuple<int, int> cord2)
    {
        return Math.Sqrt(Math.Pow(cord1.Item1 - cord2.Item1,2) + Math.Pow(cord1.Item2 - cord2.Item2,2));
    }

    private static double Time(double distance, int speed)
    {
        return distance / speed;
    }
}