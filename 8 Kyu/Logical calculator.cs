using System;
using System.Linq;
public class Kata
{
  public static bool LogicalCalc(bool[] arr, string op)
  {
      switch (op)
      {
          case "AND":
              return arr.Aggregate((a, b) => a & b);
          case "OR":
              return arr.Aggregate((a, b) => a | b);
          case "XOR":
              return arr.Aggregate((a, b) => a ^ b);
          default:
              throw new ArgumentException("op is an invalid operator.");
      }
  }
}