public class Kata
{
  public static string Greet(string name, string owner)
  {
    return name.Equals(owner) ? "Hello boss" : "Hello guest";
  }  
}