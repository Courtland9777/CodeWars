using System.Linq;

public static class Kata {
    public static int TotalPoints(string[] games) {
        int points = 0;
        for (int i = 0; i < games.Length; i++)
        {
            var arr = new int[2];
            arr = games[i].Split(':').Select(int.Parse).ToArray();
            if (arr[0] == arr[1]) points += 1;
            else if (arr[0] > arr[1]) points += 3;
        }
        return points;
    }
}