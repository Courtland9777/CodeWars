using System;

public class Kata
{
	public static int[] Get_size(int w,int h,int d)
	{
		return new int[] { 2*(h * w) + 2*(h * d) + 2*(w * d), w*h*d };
	}
}