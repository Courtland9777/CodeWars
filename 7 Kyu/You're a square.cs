using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    double sq1 = Math.Sqrt( n );
    
   int sq2 = (int)Math.Sqrt( n );
    
   if ( sq1 == (double)sq2 )
       {return true;}
   return false;
  }
}