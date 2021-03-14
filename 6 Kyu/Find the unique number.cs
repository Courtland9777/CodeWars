using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    
   var q =
    from g in numbers.GroupBy(x => x)
    where g.Count() == 1
    select g.First();
    foreach(var item in q)
    {
        return item;
    }
    return 0;
  }
}