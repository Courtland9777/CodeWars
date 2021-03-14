namespace Kata {
  using System;
  using System.Linq;
  public class ArrayMath
  {
    public static int Product(int[] values)
    {
      return values == null ? throw new ArgumentNullException() : values.Length == 0 ? throw new InvalidOperationException() : values.Aggregate((a, b) => a * b);
    }
  }
}