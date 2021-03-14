public class Greetings
{
	public static string greet(string name) => string.IsNullOrEmpty(name) ? null : $"hello {name}!";
}