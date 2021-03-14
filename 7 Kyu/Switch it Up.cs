using System;
public class Kata
{
  public static string SwitchItUp(int number)
  {
    switch (number)
    {
        case 1:
            return "One";
        case 2:
            return "Two";
        case 3:
            return "Three";
        case 4:
            return "Four";
        case 5:
            return "Five";
        case 6:
            return "Six";
        case 7:
            return "Seven";
        case 8:
            return "Eight";
        case 9:
            return "Nine";
        case 0:
            return "Zero";
        default:
            throw new ArgumentOutOfRangeException(number.ToString(),number ,"Must be a number between 0-9.");
    }
  }
}