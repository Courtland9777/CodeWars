using System;
using System.Collections.Generic;

public class ConnectFour
{
    private class Board
    {
        private readonly int[,] _grid;

        public Board()
        {
            _grid = new int[6, 7];
        }

        public void AddPiece(string pieceStr, string columnStr)
        {
            int column = LetterToInt(columnStr);
            int piece = ColorToInt(pieceStr);
            for (int i = 0; i < 6; i++)
            {
                if (_grid[i, column] == 0)
                {
                    _grid[i, column] = piece;
                    break;
                }
            }
        }

        public bool IsWinner(string player)
        {
            int XO = ColorToInt(player);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    //Horizontal Check
                    if (j < 4 && _grid[i, j] == XO &&
                                 _grid[i, j + 1] == XO &&
                                 _grid[i, j + 2] == XO &&
                                 _grid[i, j + 3] == XO)
                    {
                        return true;
                    }

                    //Diagional Check
                    if (i < 4 && j < 4 && _grid[i, j] == XO &&
                                          _grid[i + 1, j + 1] == XO &&
                                          _grid[i + 2, j + 2] == XO &&
                                          _grid[i + 3, j + 3] == XO)
                    {
                        return true;
                    }

                    if (i < 3 && j > 2 && _grid[i, j] == XO &&
                                          _grid[i + 1, j - 1] == XO &&
                                          _grid[i + 2, j - 2] == XO &&
                                          _grid[i + 3, j - 3] == XO)
                    {
                        return true;
                    }

                    //Vertical Check
                    if (i < 3 && _grid[i, j] == XO &&
                                 _grid[i + 1, j] == XO &&
                                 _grid[i + 2, j] == XO &&
                                 _grid[i + 3, j] == XO)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static int ColorToInt(string color)
        {
            if (color.Equals("Red")) return 1;
            else if (color.Equals("Yellow")) return 2;
            else return -1;
        }

        private static int LetterToInt(string letter)
        {
            switch (letter)
            {
                case "A": return 0;
                case "B": return 1;
                case "C": return 2;
                case "D": return 3;
                case "E": return 4;
                case "F": return 5;
                case "G": return 6;
                default: return -1;
            }
        }
    }

    public static string WhoIsWinner(List<string> piecesPositionList)
    {
        var gameBoard = new Board();
        int counter = 1;
        
        foreach (string item in piecesPositionList)
        {
            string dropColumn = item.Substring(0, 1);
            string player = item.Substring(2, item.Length - 2);
            gameBoard.AddPiece(player, dropColumn);
            if (counter > 4 && gameBoard.IsWinner(player)) return player;
            counter++;
        }

        return "Draw";
    }
}