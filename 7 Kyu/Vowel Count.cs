using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        return str.Count(c => vowels.Contains(c));;
    }
}