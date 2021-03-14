using System;
using System.Collections.Generic;
class Kata
{
  public static int PsionPowerPoints(int level, int score)
  {
      if(score < 11 || level < 1) return 0;
      int modifier =  score / 2 - 5;
      if(modifier % 2 != 0) modifier -= 1;
      return PPPerDay(level) + ((level*modifier)/2); 
  }
  
  public static int PPPerDay(int level) 
  {
      var dict = new Dictionary<int, int>
      {
          {1,2},
          {2,6},
          {3,11},
          {4,17},
          {5,25},
          {6,35},
          {7,46},
          {8,58},
          {9,72},
          {10,88},
          {11,106},
          {12,126},
          {13,147},
          {14,170},
          {15,195},
          {16,221},
          {17,250},
          {18,280},
          {19,311},
          {20,343},
      };
      return level < 21 ? dict[level] : dict[20];
  }
}