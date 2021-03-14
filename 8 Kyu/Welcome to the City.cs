using System.Linq;
public class Kata
{
  public static string SayHello(string name, string city, string state)
  {
    return $"Hello, {name}! Welcome to {city}, {state}!";
  }
  public static string SayHello(string[] name, string city, string state)
  {
    return $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
  }
}