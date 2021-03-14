using System;

public class GpsSpeed {
    
    public static int Gps(int s, double[] x) {
        double n = 0;
        for (int i = 0; i < x.Length-1; i++)
        {
            var temp = (3600 * (x[i + 1] - x[i]))/s;
            if (temp > n) n = temp;
        }
        return (int)Math.Floor(n);
    }
}