using System;
using System.Collections.Generic;
using System.Linq;

public class RailFenceCipher
{
    public static string Encode(string s, int n)
    {
        Console.WriteLine(s.Length);
        var arr = new string[n];
        var strArr = s.ToCharArray();
        int counter = 0;
        bool up = true;
        for (int i = 0; i < s.Length; i++)
        {
            arr[counter] += strArr[i].ToString();
            if (up)
            {
                if (counter == n-1)
                {
                    up = false;
                    counter--;
                    continue;
                }

                counter++;
            }
            else
            {
                if (counter == 0)
                {
                    up = true;
                    counter++;
                    continue;
                }

                counter--;
            }
        }
        return string.Concat(arr);
    }

    public static string Decode(string s, int n)
    {
        if (n < 2 || s.Length == 0) return "";
        int[] trackLen = CalculateTrackLen(s, n);
        var list = FillTextToRails(s, trackLen, n);

        var decodeStr = string.Empty;
        var trackIdx = 0;
        var direction = 1;
        var directionCount = 0;
        for (int i = 0; i < s.Length; i++)
        {
            decodeStr += char.ToString(list[trackIdx].First());
            list[trackIdx] = list[trackIdx].Remove(0, 1);
            trackIdx += direction;
            directionCount++;
            if (directionCount != n - 1) continue;
            direction *= -1;
            directionCount = 0;
        }
        return decodeStr;
    }

    private static int[] CalculateTrackLen(string input, int n)
    {
        var dumb = new string[n];
        var indexTrack = 0;
        var direction = 1;
        var directionCount = 0;
        for (int i = 0; i < input.Length; i++)
        {
            dumb[indexTrack] += input[i];
            indexTrack += direction;
            directionCount++;
            if (directionCount != n - 1) continue;
            direction *= -1;
            directionCount = 0;
        }
        return dumb.Select(s => s.Length).ToArray();
    }

    private static List<string> FillTextToRails(string input, IReadOnlyList<int> trackLen, int n)
    {
        var list = new List<string>();
        var cur = 0;
        foreach (var i in Enumerable.Range(0, n))
        {
            var k = input.Substring(cur, trackLen[i]);
            list.Add(k);
            cur += trackLen[i];
        }
        return list;
    }
}