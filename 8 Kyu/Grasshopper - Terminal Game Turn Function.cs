using static Game.Logic;

public class Kata
{
  public static void DoTurn()
  {
    RollDice();
    Move();
    Combat();
    GetCoins();
    BuyHealth();
    PrintStatus();
  }
}