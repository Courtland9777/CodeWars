using System;
using System.Linq;

public class Kata
{
  public static int Product(string str) => str.Count(x => x.Equals('!')) * str.Count(x => x.Equals('?'));
}