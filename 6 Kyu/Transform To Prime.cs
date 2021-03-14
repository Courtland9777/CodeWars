using System;
using System.Linq;

namespace TransformToPrime
{
  class Solution
  {
    public static int MinimumNumber(int[] numbers)
    {
        int counter = 0, sum = numbers.Sum();
        while (!CheckPrime(sum + counter))
        {
            counter++;
        }

        return counter;
    }

    private static bool CheckPrime(int num)
    {
        if (num % 2 == 0) return false;
        for (int i = 3; i < num; i += 2)
            if (num % i == 0) return false;
        return true;
    }
  }
}