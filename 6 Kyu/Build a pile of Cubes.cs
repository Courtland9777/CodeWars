using System;
public class ASum {
	
	public static long findNb(long m) {
		var nCounter = 2;
    long result = 1;
    do
    {
        result += (long) Math.Pow(nCounter, 3);
        if (result == m) return nCounter;
        nCounter++;
    }while(result < m);

    return -1;
	}
}