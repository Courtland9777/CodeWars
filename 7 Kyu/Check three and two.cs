using System;
using System.Linq;
public class Kata
{
    public static bool CheckThreeAndTwo(string[] array) =>
       array.GroupBy(o => o).Count(o => o.Count() == 3) == 1 && array.Distinct().Count() == 2;
}