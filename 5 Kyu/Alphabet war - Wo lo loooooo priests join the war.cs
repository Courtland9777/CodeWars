using System;
using System.Collections.Generic;

public class Kata
{
    public static string AlphabetWar(string fight)
    {
        var leftDict = LeftSide();
        var rightDict = RightSide();
        char[] arr = fight.ToCharArray();
        arr = FindPriests(arr, leftDict, rightDict);
        int leftSum = 0, rightSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if(leftDict.ContainsKey(arr[i]))
            {
                leftSum += leftDict[arr[i]];
            }
            else if (rightDict.ContainsKey(arr[i]))
            {
                rightSum += rightDict[arr[i]];
            }
        }

        if (rightSum > leftSum) return "Right side wins!";
        else if (leftSum > rightSum) return "Left side wins!";
        else return "Let's fight again!";
    }

    private static char[] FindPriests(char[] arr, Dictionary<char, int> leftDict, Dictionary<char, int> rightDict)
    {
        var convDict = ConversionDict();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 't' || arr[i] == 'j')
            {
                if (arr[i] == 't' && (i + 1) != arr.Length && rightDict.ContainsKey(arr[i + 1]))
                {
                    if ((i + 2) >= arr.Length || arr[i + 2] != 'j')
                    {
                        arr[i+1] = convDict[arr[i+1]];
                    }
                }
                if (arr[i] == 't' && (i - 1) != -1 && rightDict.ContainsKey(arr[i - 1]))
                {
                    if ((i - 2) < 0 || arr[i - 2] != 'j')
                    {
                        arr[i-1] = convDict[arr[i-1]];
                    }
                }
                if (arr[i] == 'j' && (i + 1) != arr.Length && leftDict.ContainsKey(arr[i + 1]))
                {
                    if ((i + 2) >= arr.Length || arr[i + 2] != 't')
                    {
                        arr[i+1] = convDict[arr[i+1]];
                    }
                }
                if (arr[i] == 'j' && (i - 1) != -1 && leftDict.ContainsKey(arr[i - 1]))
                {
                    if ((i - 2) < 0 || arr[i - 2] != 't')
                    {
                        arr[i-1] = convDict[arr[i-1]];
                    }
                }
            }
        }

        return arr;
    }

    private static Dictionary<char,int> LeftSide()
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

    private static Dictionary<char, char> ConversionDict()
    {
        var dict = new Dictionary<char, char>
        {
            { 'm', 'w' },
            { 'q', 'p' },
            { 'd', 'b' },
            { 'z', 's' },
            { 'w', 'm' },
            { 'p', 'q' },
            { 'b', 'd' },
            { 's', 'z' },
        };
        return dict;
    }
 }