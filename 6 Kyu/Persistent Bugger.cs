using System;
using System.Linq;

public class Persist 
{
  public static int Persistence(long n) 
  {
    int counter = 0;
    while (n > 9)
    {
        n = n.ToString().ToCharArray().Select(x => x - '0').Aggregate((a, b) => a * b);
        counter++;
    }
    return counter;
  }
}