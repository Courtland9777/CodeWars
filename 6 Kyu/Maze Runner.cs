using System;
namespace CodeWars
{
    public static class ExtensionMethods
    {
        public static Tuple<int, int> CoordinatesOf<T>(this T[,] matrix, T value)
        {
            int w = matrix.GetLength(0); // width
            int h = matrix.GetLength(1); // height
  
            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    if (matrix[x, y].Equals(value))
                        return Tuple.Create(x, y);
                }
            }
  
            return Tuple.Create(-1, -1);
        }
    }
    
    class Kata
    {
        public string mazeRunner(int[,] maze, string[] directions)
        {
            const string lost = "Lost";
            const string dead = "Dead";
            const string finish = "Finish";

            int x, y;
            (y, x) = maze.CoordinatesOf(2);
            if ((x == -1 && y == -1) || directions.Length == 0) return "";

            foreach (var t in directions)
            {
                switch (t)
                {
                    case "N": y--;
                        break;
                    case "S":
                        y++;
                        break;
                    case "E":
                        x++;
                        break;
                    case "W":
                        x--;
                        break;
                    default:
                        throw new ArgumentException("Invalid directions string.");
                }

                if (x < 0 || y < 0 || x == maze.GetLength(1) || y == maze.GetLength(0)) return dead;

                switch (maze[y,x])
                {
                    case 0:
                        break;
                    case 1:
                        return dead;
                    case 2:
                        break;
                    case 3:
                        return finish;
                    default:
                        throw new ArgumentException("Invalid maze input.");
                }
            }

            return lost;
        }
    }
}