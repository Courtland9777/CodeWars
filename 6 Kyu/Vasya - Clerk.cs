using System;

public class Line
    {
         public static string Tickets(int[] peopleInLine)
        { 
      int twentyfive = 0;
      int fifty = 0;
            for (int i = 0; i < peopleInLine.Length; i++)
      {
        if (peopleInLine[i] == 25)
        {
          twentyfive += 1;
        }
        else if (peopleInLine[i] == 50 && twentyfive > 0) 
        {
          twentyfive -= 1;
          fifty += 1;
        }
        else if (peopleInLine[i] == 100 && twentyfive > 0 && fifty > 0) 
        {
          twentyfive -= 1;
          fifty -= 1;
        }
        else if (peopleInLine[i] == 100 && twentyfive > 2) 
        {
          twentyfive -= 3;
        }       
        else
        {return "NO";}
      }
      return "YES";
        }
    }