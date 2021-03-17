using System;
public class BouncingBall {
	
	public static int bouncingBall(double h, double bounce, double window) {
    if (h <= 0 || window >= h || (bounce < 0 || bounce >= 1)) return -1;
    var bounceCount = 1;
    for (var i = h * bounce; i > window; i*=bounce)
    {
        bounceCount += 2;
    }
    return bounceCount;
	}
}