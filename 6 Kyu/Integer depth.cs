using System.Collections.Generic;
namespace Solution 
{
  public class Kata 
  {
 
    public static int ComputeDepth(int n)
    {
        var dict = new Dictionary<char, bool>
        {
            { '0', false },
            { '1', false },
            { '2', false },
            { '3', false },
            { '4', false },
            { '5', false },
            { '6', false },
            { '7', false },
            { '8', false },
            { '9', false }
        };

        int counter = 0;
        do
        {
            var temp = n * (counter + 1);
            var arr = temp.ToString().ToCharArray();
            foreach (var c in arr)
            {
                dict[c] = true;
            }
            counter++;
            temp = 0;
        } while (dict.ContainsValue(false));
        return counter;
    }
  
  }
}