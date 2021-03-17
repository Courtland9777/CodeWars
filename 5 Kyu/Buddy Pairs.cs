using System;
class Bud
{
	public static string Buddy(long start, long limit)
	{
		for (var n = start; n <= limit; n++)
    {
        var nDivSum = SumDivisors(n);
        var m = nDivSum - 1;
        var mDivSum = SumDivisors(m);
        if (mDivSum != n + 1) continue;
        if(n >= m) continue;
        return $"({n} {m})";
    }
    return "Nothing";
	}
  
  private static long SumDivisors(long n)
  {
      if (n == 1)
          return 1;

      long result = 0;

      for (long i = 2; i <= Math.Sqrt(n); i++)
      {
          if (n % i != 0) continue;
          if (i == (n / i))
              result += i;
          else
              result += i + (n / i);
      }

      return result + 1;
  }
}