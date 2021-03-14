public class Kata
{
    public static bool Feast(string beast, string dish)
    {
        return beast[0].Equals(dish[0]) && beast[beast.Length-1].Equals(dish[dish.Length-1]);
    }
}