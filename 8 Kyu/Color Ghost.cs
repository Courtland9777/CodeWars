using System;
using System.Collections.Generic;
public class Ghost
{
  public string color { get; set; }
  
  public Ghost()
        {
            var random = new Random();
            var list = new List<string> { "white" , "yellow" , "purple" , "red" };
            this.color = list[random.Next(list.Count)];
        }
  
  public string GetColor()
  {
    return this.color;
  }
}