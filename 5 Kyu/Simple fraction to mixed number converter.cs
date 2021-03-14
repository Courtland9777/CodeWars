using System;
public class Kata
{
    public static string MixedFraction(string s)
    {
        var arr = s.Split('/');
        var num = int.Parse(arr[0]);
        var den = int.Parse(arr[1]);
        if (den == 0) throw new DivideByZeroException();
        if (num == 0) return "0";
        bool neg = ((num < 0 && den > 0) || (num > 0 && den < 0));
        num = Math.Abs(num);
        den = Math.Abs(den);
        var mix = (num - (num % den)) / den;
        if (neg && mix != 0) mix *= -1;
        num %= den;
        if (mix == 0) return neg ? $"-{ReduceFraction(num, den)}" : $"{ReduceFraction(num, den)}";
        return $"{mix} {ReduceFraction(num, den)}".Trim();
    }

    private static string ReduceFraction(int x, int y)
    {
        int d = Gcd(x, y);

        x /= d;
        y /= d;

        return x == 0 ? "" : $"{x}/{y}";
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}