using System;
using System.Linq;

public static class Kata
{
    public static bool Digit(this string s) => s.Length == 1 && !string.IsNullOrWhiteSpace(s) && s.All(char.IsNumber);
}