using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    if (numbers.Count() == 0) {return numbers;}
    foreach (var num in numbers.ToList())
    {
      if (num == numbers.Min())
      {
        numbers.Remove(num);
        return numbers;
      }
    }
    return numbers;
  }
}