using System;
public class Dinglemouse
{
    public class Player
    {
        public string Name { get; }
        public int Points { get; set; }
        public int Games { get; set; }
    
        public Player(string name)
        {
            Name = name;
            Points = 0;
            Games = 0;
        }
    
        public string ConvertScore()
        {
            switch (this.Points)
            {
                case 0: return "0";
                case 1: return "15";
                case 2: return "30";
                case 3: return "40";
                default: return "AD";
            }
        }
    }
    
    public class Game
    {
        public int GameCount { get; private set; }
        public Player Server { get; private set; }
        public Player Receiver { get; private set; }
    
        public Game(Player Player1, Player Player2)
        {
            GameCount = 1;
            Server = Player1;
            Receiver = Player2;
        }
    
        public void NewGame()
        {
            GameCount++;
            Server.Points = 0;
            Receiver.Points = 0;
            Player temp = Server;
            Server = Receiver;
            Receiver = temp;
        }
    }
    
    public static string[][] Wimbledon(bool[] balls)
    {
        var Player1 = new Player("P1");
        var Player2 = new Player("P2");
        var CurrentGame = new Game(Player1, Player2);
        int volleyCount = 0;
        int faultCount = 0;
        
        for (int i = 0; i < balls.Length; i++)
        {
            if (!balls[i])
            {          
                faultCount++;
                if(volleyCount > 0)
                {
                    volleyCount = 0;
                    faultCount = 0;
                }
                if (faultCount == 2)
                {
                    CurrentGame.Receiver.Points++;
                    GameWinCheck(Player1,Player2,CurrentGame);
                    faultCount = 0;
                }
            }
            else if (balls[i])
            {
                faultCount = 0;
                volleyCount++;
                if(i+1 == balls.Length || !balls[i+1])
                {
                    if(volleyCount % 2 == 0)
                    {
                        CurrentGame.Receiver.Points++;
                        GameWinCheck(Player1,Player2,CurrentGame);
                    }
                    else
                    {
                        CurrentGame.Server.Points++;
                        GameWinCheck(Player1,Player2,CurrentGame);
                    }
                }
            }
            if(Player1.Points == 4 && Player2.Points == 4)
            {
                Player1.Points--;
                Player2.Points--;
            }
        }
    
        return new string[][]
         {
            // Games  Score
            new[]{  Player1.Games.ToString(),   Player1.ConvertScore()  },  // P1
            new[]{  Player2.Games.ToString(),   Player2.ConvertScore()  }   // P2
         };
    }
    
    public static void GameWinCheck(Player P1, Player P2, Game game)
    {
        if (P1.Points >= 4 && P1.Points >= P2.Points + 2)
        {
            P1.Games++;
            game.NewGame();
        }
    
        else if (P2.Points >= 4 && P2.Points >= P1.Points + 2)
        {
            P2.Games++;
            game.NewGame();
        }
    }
}