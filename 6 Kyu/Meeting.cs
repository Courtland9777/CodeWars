using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string First { get; }
    public string Last { get; }

    public Person(string name)
    {
        var arr = name.Split(':');
        First = arr[0].ToUpper();
        Last = arr[1].ToUpper();
    }

    public override string ToString()
    {
        return $"({Last}, {First})";
    }
}

public class JohnMeeting
{
  public static string Meeting(string s)
  {
      var arr = s.Split(';');
      var list = new List<Person>();
      for (int i = 0; i < arr.Length; i++)
      {
          list.Add(new Person(arr[i]));
      }

      return string.Join("", list.OrderBy(x => x.Last).ThenBy(x => x.First));
  }
}