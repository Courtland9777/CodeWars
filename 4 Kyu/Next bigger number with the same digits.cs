using System;
public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        char[] arr = n.ToString().ToCharArray();
        int len = arr.Length;

        int i;

        for (i = len - 1; i > 0; i--)
        {
            if (arr[i] > arr[i - 1])
            {
                break;
            }
        }

        if (i == 0)
        {
            return -1;
        }

        int x = arr[i - 1], min = i;

        for (int j = i + 1; j < len; j++)
        {
            if (arr[j] > x && arr[j] < arr[min])
            {
                min = j;
            }
        }

        Swap(arr, i - 1, min);

        Array.Sort(arr, i, len - i);

        string returnStr = "";
        for (i = 0; i < len; i++)
            returnStr += arr[i];

        return long.Parse(returnStr);
    }

    private static void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}