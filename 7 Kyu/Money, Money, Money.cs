using System;

public class Kata
{
  public static int CalculateYears(double principal, double interest,  double tax, double desiredPrincipal)
        {
          int years = 0;
            while (principal < desiredPrincipal)
            {
                double pretaxInt = (principal * interest);
                double posttaxInt = pretaxInt - (pretaxInt * tax);
                principal += posttaxInt;
                years++;
            }; 

            return years;
        }
}