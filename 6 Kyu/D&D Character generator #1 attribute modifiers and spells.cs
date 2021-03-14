using System;
using System.Linq;
class Kata
{
  public static (int, int, int[]) CharAttribute(int score)
  {
    if(score <= 0) return (0, -1 ,new int[0]);
    int modifier = score / 2 - 5;
    int maxSpellLvl;    
    int[] extraSpells;
    if(modifier < 0)
    {
        maxSpellLvl = -1;
        extraSpells = new int[0];
    }
    else
    {
        maxSpellLvl = Math.Min(9, score - 10);
        extraSpells = Enumerable.Range(0, score / 2 - 5).Select(n => 1 + n / 4).Reverse().Take(9).ToArray();
    }
    return (modifier, maxSpellLvl, extraSpells);  
  }
}