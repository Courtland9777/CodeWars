using System;
using System.Linq;
public static class Kata
    {
        public static int CountLettersAndDigits(string input) =>
          input.Count(c => char.IsLetterOrDigit(c));
    }