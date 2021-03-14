using System;
using System.Linq;
public class Kata
{
  public static string InitializeNames(string name)
  {
    var arr = name.Split(' ');
    return arr.Length > 2 ? $"{arr[0]} {string.Join(" ", arr.Skip(1).Take(arr.Length - 2).Select(x => $"{x[0]}."))} {arr.Last()}" : name;
  }
}