using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    var nList = list.ToList();
    nList.Reverse();
    return nList;
  }
}