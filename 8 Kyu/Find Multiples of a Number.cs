using System.Collections.Generic;

public class Kata
{
  public static List<int> FindMultiples(int integer, int limit)
  {
    int counter = 1;
    var list = new List<int>();
    int temp;
    do
    {
        temp = counter * integer;
        if(temp <= limit) list.Add(temp);
        counter++;
    } while (temp < limit);

    return list;
  }
}