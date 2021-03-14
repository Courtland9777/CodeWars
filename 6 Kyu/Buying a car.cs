using System;

public class BuyCar {

  public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth) {
    if (startPriceOld >= startPriceNew)
        {
            return new int[]{0, startPriceOld - startPriceNew};
        }
        
        percentLossByMonth /= 100;
        
        double moneySaved = 0;
        double cCarValue = startPriceOld;
        double nCarValue = startPriceNew;
        int monthCounter = 0;
        do
        {
            cCarValue -= (cCarValue * percentLossByMonth);
            nCarValue -= (nCarValue * percentLossByMonth);
            //Console.WriteLine("cCarValue: " + cCarValue + "  NCarValue: " + nCarValue);
            moneySaved += savingPerMonth;
            monthCounter++;
            if(monthCounter % 2 != 0)
            {
                percentLossByMonth += 0.005;
            }
        }while((moneySaved + cCarValue) < nCarValue);
        
        Console.WriteLine("cCarValue: " + cCarValue + "  moneySaved: " + moneySaved + "  NCarValue: " + nCarValue);
        
        return new int[]{monthCounter, (int)Math.Round((moneySaved + cCarValue) - nCarValue)};
  }
}