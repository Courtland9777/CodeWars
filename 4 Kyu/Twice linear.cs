using System;
using System.Collections.Generic;

public class DoubleLinear 
{
    
    public static int DblLinear(int n)
    {
        var list = new List<int>
        {
            1
        };
        int x = 0, y = 0;
        for (int i = 0; i < n; i++)
        {
            var nextX = 2 * list[x] + 1;
            var nextY = 3 * list[y] + 1;
            if (nextX <= nextY)
            {
                list.Add(nextX);
                x++;
                if (nextX == nextY)
                    y++;
            }
            else
            {
                list.Add(nextY);
                y++;
            }
        }

        return list[n];
    }
}