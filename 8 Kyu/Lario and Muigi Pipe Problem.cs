using System.Collections.Generic;
using System.Linq;

public class Fixer
{
  public static List<int> PipeFix(List<int> numbers)
  {
    return Enumerable.Range(numbers.Min(), numbers.Max()-numbers.Min()+1).ToList();
  }
}