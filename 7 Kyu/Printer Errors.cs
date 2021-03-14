using System;

public class Printer 
{
    public static string PrinterError(String s) 
    {
        char[] arr = s.ToCharArray();
        int errorCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 109 && arr[i] < 123)
            {
                errorCount++;
            }
        }
        return errorCount + "/" + arr.Length;
    }
}