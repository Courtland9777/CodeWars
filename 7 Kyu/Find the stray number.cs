using System.Linq;

class Solution 
{
  public static int Stray(int[] numbers)
  {
    return numbers.GroupBy(x=>x).Single(x=> x.Count() == 1).Key;
  }
}