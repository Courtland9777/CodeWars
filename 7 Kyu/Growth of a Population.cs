using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) 
    {
        int cPop = p0;
        int yearCounter = 0;
        
        if(percent > 0) percent /= 100;
        
        do
        {
            cPop = cPop + (int)(cPop * percent) + aug;
            yearCounter++;
        }while(cPop < p);
        return yearCounter;
    }
}