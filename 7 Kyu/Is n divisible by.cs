using System;
using System.Linq;
namespace Codewars {
  public static class KataChallenge {
    public static bool IsDivisible(params int[] arr) =>
        arr.Skip(1).All(x => arr[0] % x == 0);
  }
}