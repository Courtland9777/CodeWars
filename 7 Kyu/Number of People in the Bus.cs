using System;
using System.Collections.Generic;

public class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int busRider = 0;
            foreach (var item in peopleListInOut)
            {
                busRider += item[0] - item[1];
            }
            return busRider;
        }
    }