using System;
using System.Collections.Generic;
using System.Linq;
 public class Kata
 {
   public static string AlphabetWar(string fight)
    {
        int temp;
        do
        {
            temp = fight.Length;
            fight = fight.Replace("**", "*");
        } while (fight.Length != temp);

        const string lfa = "Let's fight again!";
        if (LfaCheck(fight)) return lfa;
        fight = EndCleaner(fight);
        if (LfaCheck(fight)) return lfa;

        var arr = fight.ToCharArray();
        if (fight.Contains("*"))
        {
            for (int i = 1; i < fight.Length - 1; i++)
            {
                if (!arr[i].Equals('*')) continue;
                arr[i - 1] = ' ';
                arr[i + 1] = ' ';
                arr[i] = ' ';
            }

            arr = string.Concat(arr).ToCharArray();
            if (LfaCheck(fight)) return lfa;
        }

        Dictionary<char, int> left = LeftSide(), right = RightSide();
        int l = 0, r = 0;
        foreach (var t in arr)
        {
            if (left.ContainsKey(t)) l += left[t];
            if (right.ContainsKey(t)) r += right[t];
        }

        return l > r ? "Left side wins!" : r > l ? "Right side wins!" : lfa;
    }

    private static bool LfaCheck(string fight)
    {
        return fight.Length == 0 || (fight.Length <= 2 && fight.Contains('*'));
    }

    private static string EndCleaner(string fight)
    {
        while (fight[0].Equals('*') && fight.Length > 2)
        {
            fight = fight.Substring(2);
        }

        while (fight.Last().Equals('*') && fight.Length > 2)
        {
            fight = fight.Substring(0,fight.Length-2);
        }

        return fight;
    }

    private static Dictionary<char, int> LeftSide()
    {
        var dict = new Dictionary<char, int>
        {
            { 'w', 4 },
            { 'p', 3 },
            { 'b', 2 },
            { 's', 1 }
        };
        return dict;
    }

    private static Dictionary<char, int> RightSide()
    {
        var dict = new Dictionary<char, int>
        {
            { 'm', 4 },
            { 'q', 3 },
            { 'd', 2 },
            { 'z', 1 }
        };
        return dict;
    }
 }