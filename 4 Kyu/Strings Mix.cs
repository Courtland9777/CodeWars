using System;
using System.Linq;

public class GroupOfCharacters
{
    public char Character { get; private set; }
    public int Count { get; set; }
    public int ListNumber { get; set; }

    public GroupOfCharacters(char c, int count, int listNumber)
    {
        Character = c;
        Count = count;
        ListNumber = listNumber;
    }
}

public class Mixing 
{
  public static string Mix(string s1, string s2)
  {
      if (s1.Equals("") && s2.Equals("")) return "";
      var str1 = string.Join("", s1.Where(char.IsLetter).Where(char.IsLower).ToArray()).GroupBy(x => x).Select(x => new GroupOfCharacters(x.Key, x.Count(), 1)).ToDictionary(item => item.Character, item => item);
      var str2 = string.Join("", s2.Where(char.IsLetter).Where(char.IsLower).ToArray()).GroupBy(x => x).Select(x => new GroupOfCharacters(x.Key, x.Count(), 2));

      foreach (var item in str2)
      {
          if (!str1.ContainsKey(item.Character)) str1.Add(item.Character, item);
          else if (str1[item.Character].Count == item.Count) str1[item.Character].ListNumber = 3;
          else if (str1[item.Character].Count < item.Count)
          {
              str1[item.Character].ListNumber = 2;
              str1[item.Character].Count = item.Count;
          }
      }

      var sortedKeyValuePairs = str1.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value.ListNumber).ThenBy(x => x.Value.Character);
      string result = "";
      foreach (var item in sortedKeyValuePairs)
      {
          if(item.Value.Count > 1) result += StrConverter(item.Value.Character, item.Value.Count, item.Value.ListNumber);
      }

      return result.Length > 0 ? result.Substring(0,result.Length-1) : "";
  }

  public static string StrConverter(char letter, int count, int fromStr)
  {
      string rtnStr = "";
      string temp = "";
      if (fromStr < 3)
      {
          for (int i = 0; i < count; i++)
          {
              temp += letter.ToString();
          }
          rtnStr = $"{fromStr}:{temp}/";
      }
      else
      {
          for (int i = 0; i < count; i++)
          {
              temp += letter.ToString();
          }
          rtnStr = $"=:{temp}/";
      }
      return rtnStr;
  }
}