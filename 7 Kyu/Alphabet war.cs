using System;
using System.Collections.Generic;

 public class Kata
 {
    public static string AlphabetWar(string fight)
    {
        var leftDict = LeftSide();
        var rightDict = RightSide();
        char[] arr = fight.ToCharArray();
        int leftSum = 0, rightSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (leftDict.ContainsKey(arr[i]))
            {
                leftSum += leftDict[arr[i]];
            }
            else if (rightDict.ContainsKey(arr[i]))
            {
                rightSum += rightDict[arr[i]];
            }
        }

        return rightSum > leftSum ? "Right side wins!" :
            leftSum > rightSum ? "Left side wins!" : "Let's fight again!";
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