public class Kata
{
    public static string UpdateLight(string current)
    {
        return current.Equals("green") ? "yellow" : current.Equals("yellow") ? "red" : "green";
    }
}