public class Kata
{
  public static string Stringify(Node list)
  {
    Node temp = list;
    string nodeString = string.Empty;
    while (temp != null)
    {
        nodeString += $"{temp.Data.ToString()} -> ";
        temp = temp.Next;
    }
    return nodeString + "null";
  }
}