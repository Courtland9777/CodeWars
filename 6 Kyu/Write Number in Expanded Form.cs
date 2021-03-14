using System;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
       string expForm = "";
       char[] arr = num.ToString().ToCharArray();
       Array.Reverse(arr);
       string zeroCounter = "";
       for (int i = 0; i < arr.Length; i++)
        {
            if (!arr[i].ToString().Equals("0"))
            {
                if (expForm.Length == 0)
                { 
                    expForm = arr[i].ToString() + zeroCounter;
                }
                else
                {
                    expForm = arr[i].ToString() + zeroCounter + " + " + expForm;
                }               
            }
            zeroCounter += "0";
        }
        Console.WriteLine("expForm: " + expForm);
       return expForm;
    }
}