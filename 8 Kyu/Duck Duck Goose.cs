using System;
using System.Linq;
public class Kata
{
  public static string DuckDuckGoose(Player[] players, int goose)
  {
  foreach(var player in players){
    Console.WriteLine(player.Name);
    }
    if (goose <= 0) return "";
    if (goose > players.Length && goose % players.Length - 1 < 0) return players.ElementAt(players.Length - 1).Name;
    if (goose > players.Length) return players.ElementAt(goose % players.Length - 1).Name;
    return players.ElementAt(goose - 1).Name;
  }
}
public class Player 
{
  public string Name {get;set;}
  
  public Player (string name) 
  {
    this.Name = name;
  }
}