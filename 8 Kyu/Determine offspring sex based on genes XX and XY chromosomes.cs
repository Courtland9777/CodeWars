public class Kata
{
  public static string ChromosomeCheck(string sperm) =>
    sperm.Contains("Y") ? "Congratulations! You're going to have a son." : "Congratulations! You're going to have a daughter.";
}