using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public string Rps(string p1, string p2)
  {
    if(p1.Equals(p2)) return "Draw!";
    
    string p1Win = "Player 1 won!";
    string p2Win = "Player 2 won!";
    
    if(p1.Equals("scissors"))
    {
        if(p2.Equals("rock")) return p2Win;
        else if (p2.Equals("paper")) return p1Win;
    }
    else if(p1.Equals("paper"))
    {
        if(p2.Equals("rock")) return p1Win;
        else if (p2.Equals("scissors")) return p2Win;
    }
    else if(p1.Equals("rock"))
    {
        if(p2.Equals("paper")) return p2Win;
        else if (p2.Equals("scissors")) return p1Win;
    }
    
    return "";
  }
}