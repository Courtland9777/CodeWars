using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata
{
    public static bool Vowel(this string s)
    {
        return "aeiou".Contains(s.ToLower()) && s.Length == 1;
    }
}