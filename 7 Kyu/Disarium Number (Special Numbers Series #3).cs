using System;
using System.Linq;
class Kata
{
    public static string DisariumNumber(int n)
    {
        return n == (int)n.ToString().Select((a, b) => Math.Pow(double.Parse(a.ToString()), (double) b + 1)).Sum()
                 ? "Disarium !!" : "Not !!"; 
    }
}