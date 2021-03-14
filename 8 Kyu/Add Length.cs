public class Kata
{
  public static string[] AddLength(string str)
  {
    var arr = str.Split(' ');
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = $"{arr[i]} {arr[i].Length}";
    }
    return arr;
  }
}