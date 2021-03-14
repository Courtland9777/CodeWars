using System;
using System.Linq;
using System.Text;

public static class Kata
{
  public static string BinaryToString(string binary) =>
    Encoding.ASCII.GetString(Enumerable.Range(0, int.MaxValue / 8)
      .Select(i => i * 8)
      .TakeWhile(i => i < binary.Length)
      .Select(i => binary.Substring(i, 8))
      .Select(s => Convert.ToByte(s, 2))
      .ToArray(), 0, binary.Length / 8);
}