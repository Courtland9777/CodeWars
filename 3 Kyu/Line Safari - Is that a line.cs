using System;
using System.Collections.Generic;
using System.Linq;

public enum ValidMoves
{
    NoValid = 0,
    Up = 1,
    Down = 2,
    Left = 3,
    Right = 4,
    Empty = 5
}

public class Dinglemouse
{
    public static bool Line(char[][] grid)
    {
        var newGrid = new LineGrid(grid);
        Console.WriteLine($"newGrid.startX1 = {newGrid.StartX1}");
        Console.WriteLine($"newGrid.startX2 = {newGrid.StartX2}");

        var start = newGrid.StartX1;
        var currentPosition = start;
        var currentPosChar = 'X';
        var end = newGrid.StartX2;

        var positionDict = new Dictionary<Tuple<int, int>, int>
        {
            { currentPosition, 0 }
        };

        var lastMove = ValidMoves.Empty;
        while (true)
        {
            var result = CheckValidMoves(newGrid, currentPosition, currentPosChar, positionDict, lastMove);
            if (result == ValidMoves.NoValid)
            {
                if (start.Equals(newGrid.StartX2)) return false;
                start = newGrid.StartX2;
                end = newGrid.StartX1;
                currentPosition = start;
                currentPosChar = 'X';
                positionDict.Clear();
                positionDict.Add(start, 0);
                continue;
            }
            //Move
            switch (result)
            {
                case ValidMoves.Up:
                    currentPosition = new Tuple<int, int>(currentPosition.Item1 - 1, currentPosition.Item2);
                    lastMove = ValidMoves.Up;
                    break;
                case ValidMoves.Down:
                    currentPosition = new Tuple<int, int>(currentPosition.Item1 + 1, currentPosition.Item2);
                    lastMove = ValidMoves.Down;
                    break;
                case ValidMoves.Right:
                    currentPosition = new Tuple<int, int>(currentPosition.Item1, currentPosition.Item2 + 1);
                    lastMove = ValidMoves.Right;
                    break;
                case ValidMoves.Left:
                    currentPosition = new Tuple<int, int>(currentPosition.Item1, currentPosition.Item2 - 1);
                    lastMove = ValidMoves.Left;
                    break;
                default:
                    throw new ArgumentException($"No valid move given - '{result}'", nameof(result));
            }

            currentPosChar = newGrid.Grid[currentPosition.Item1][currentPosition.Item2];
            positionDict.Add(currentPosition, 0);
            if (!currentPosition.Equals(end)) continue;
            var expectedBlanks = newGrid.Spaces - positionDict.Count;
            if (expectedBlanks != newGrid.Blanks) continue;
            return true;
        }
    }
    private static ValidMoves CheckValidMoves(LineGrid grid, Tuple<int, int> currentPosition, char currentPosChar, Dictionary<Tuple<int, int>, int> positionDict, ValidMoves lastMove)
    {
        var dir = new Direction(grid, currentPosition);

        switch (currentPosChar)
        {
            case '-':
                dir.IsLeft = !OnList(positionDict, currentPosition, 0, -1) && new char[] { '+', '-', 'X' }.Contains(dir.LeftChar);
                dir.IsRight = !OnList(positionDict, currentPosition, 0, 1) && new char[] { '+', '-', 'X' }.Contains(dir.RightChar);
                return dir.GetMove();
            case '|':
                dir.IsUp = !OnList(positionDict, currentPosition, -1, 0) && new char[] { '+', 'X', '|' }.Contains(dir.UpChar);
                dir.IsDown = !OnList(positionDict, currentPosition, 1, 0) && new char[] { '+', 'X', '|' }.Contains(dir.DownChar);
                return dir.GetMove();
            case '+':
                dir.IsUp = (!OnList(positionDict, currentPosition, -1, 0)) && 
                           (lastMove != ValidMoves.Down && lastMove != ValidMoves.Up && new char[] { '+', '|', 'X' }.Contains(dir.UpChar));
                dir.IsDown = (!OnList(positionDict, currentPosition, 1, 0)) && 
                             (lastMove != ValidMoves.Down && lastMove != ValidMoves.Up && new char[] { '+', '|', 'X' }.Contains(dir.DownChar));
                dir.IsLeft = !OnList(positionDict, currentPosition, 0, -1) && 
                             (lastMove != ValidMoves.Left && lastMove != ValidMoves.Right && new char[] { '+', '-', 'X' }.Contains(dir.LeftChar));
                dir.IsRight = !OnList(positionDict, currentPosition, 0, 1) && 
                              (lastMove != ValidMoves.Left && lastMove != ValidMoves.Right && new char[] { '+', '-', 'X' }.Contains(dir.RightChar));
                return dir.GetMove();
            case 'X':
                dir.IsUp = !OnList(positionDict, currentPosition, -1, 0) && new char[] { '+', 'X', '|' }.Contains(dir.UpChar);
                dir.IsDown = !OnList(positionDict, currentPosition, 1, 0) && new char[] { '+', 'X', '|' }.Contains(dir.DownChar);
                dir.IsLeft = !OnList(positionDict, currentPosition, 0, -1) && new char[] { '+', '-', 'X' }.Contains(dir.LeftChar);
                dir.IsRight = !OnList(positionDict, currentPosition, 0, 1) && new char[] { '+', '-', 'X' }.Contains(dir.RightChar);
                return dir.GetMove();
            default:
                throw new ArgumentException($"Invalid Current Position Character - '{currentPosChar}'", nameof(currentPosChar));
        }
    }

    private static bool OnList(Dictionary<Tuple<int, int>, int> positionDict, Tuple<int, int> currentPosition, int xOffset = 0, int yOffset = 0) =>
        positionDict.ContainsKey(new Tuple<int, int>(currentPosition.Item1 + xOffset, currentPosition.Item2 + yOffset));
}

public class Direction
{
    public bool IsUp { get; set; }
    public bool IsDown { get; set; }
    public bool IsLeft { get; set; }
    public bool IsRight { get; set; }
    public char UpChar { get; }
    public char DownChar { get; }
    public char RightChar { get; }
    public char LeftChar { get; }

    public Direction(LineGrid grid, Tuple<int, int> currentPosition)
    {
        UpChar = GetUp(grid, currentPosition);
        DownChar = GetDown(grid, currentPosition);
        RightChar = GetRight(grid, currentPosition);
        LeftChar = GetLeft(grid, currentPosition);
    }

    public ValidMoves GetMove() =>
        new bool[] { IsUp, IsDown, IsLeft, IsRight }.Count(x => x) != 1 ? ValidMoves.NoValid :
        IsUp ? ValidMoves.Up :
        IsDown ? ValidMoves.Down :
        IsRight ? ValidMoves.Right : ValidMoves.Left;

    private static char GetUp(LineGrid grid, Tuple<int, int> currentPosition) =>
        currentPosition.Item1 <= 0 ? ' ' : grid.Grid[currentPosition.Item1 - 1][currentPosition.Item2];

    private static char GetDown(LineGrid grid, Tuple<int, int> currentPosition) =>
        currentPosition.Item1 >= grid.RowCount - 1 ? ' ' : grid.Grid[currentPosition.Item1 + 1][currentPosition.Item2];

    private static char GetLeft(LineGrid grid, Tuple<int, int> currentPosition) =>
        currentPosition.Item2 <= 0 ? ' ' : grid.Grid[currentPosition.Item1][currentPosition.Item2 - 1];

    private static char GetRight(LineGrid grid, Tuple<int, int> currentPosition) =>
        currentPosition.Item2 >= grid.ColumnCount - 1 ? ' ' : grid.Grid[currentPosition.Item1][currentPosition.Item2 + 1];
}

public class LineGrid
{
    public readonly int RowCount;
    public readonly int ColumnCount;
    public Tuple<int, int> StartX1;
    public Tuple<int, int> StartX2;
    public readonly char[][] Grid;
    public readonly int Blanks;
    public readonly int Spaces;

    public LineGrid(char[][] grid)
    {
        Grid = grid;
        RowCount = grid.Length;
        ColumnCount = grid[0].Length;
        GetStartPoints(grid);
        Blanks = CountBlanks(grid);
        Spaces = CountTotalSpaces(grid);
    }

    private void GetStartPoints(char[][] grid)
    {
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 'X') continue;
                var startPoint = new Tuple<int, int>(i, j);
                if (StartX1 == null)
                {
                    StartX1 = startPoint;
                }
                else
                {
                    StartX2 = startPoint;
                }
            }
        }
    }
    
    private static int CountTotalSpaces(char[][] grid)
    {
        var spaces = 0;
        for (var i = 0; i < grid.Length; i++)
        {
            spaces += grid[i].Length;
        }

        return spaces;
    }
    
    private static int CountBlanks(char[][] grid)
    {
        var count = 0;
        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == ' ') count++;
            }
        }

        return count;
    }
}