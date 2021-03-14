using System;
using System.Collections.Generic;
using System.Linq;

public class Dinglemouse {

  public static string[] WhoEatsWho(string zoo)
  {    
    if(zoo.Length == 0) return new string[1] { zoo };
    var eats = new Dictionary<string, string[]>
    {
        { "antelope", new string[] { "grass" } },
        { "big-fish", new string[] { "little-fish" } },
        { "bug", new string[] { "leaves" } },
        { "bear", new string[] { "big-fish", "bug", "chicken", "cow", "leaves", "sheep" } },
        { "chicken", new string[] { "bug" } },
        { "cow", new string[] { "grass" } },
        { "fox", new string[] { "chicken", "sheep" } },
        { "giraffe", new string[] { "leaves" } },
        { "lion", new string[] { "antelope", "cow" } },
        { "panda", new string[] { "leaves" } },
        { "sheep", new string[] { "grass" } },
        { "grass", new string[] { } },
        { "leaves", new string[] { } },
        { "little-fish", new string[] { } },
        { "tree", new string[] { } },
        { "bicycle", new string[] { } },
        { "busker", new string[] { } },
        { "banana", new string[] { } }
    };
  
    var theZoo = new List<string>
    {
        zoo
    };
    string[] zooArr = zoo.Split(',');     
    int counter = 0;  
    while(zooArr.Length != 1 && counter++ < 100)
    {
        int begLen = zooArr.Length;
        for(int i = 0; i < zooArr.Length; i++)
        {
            if (i != 0 && eats[zooArr[i]].Contains(zooArr[i-1]))
            {
                theZoo.Add(zooArr[i] + " eats " + zooArr[i-1]);
                zooArr = zooArr.RemoveAt(i-1);
                break;
            }
            
            else if (i != (zooArr.Length - 1) && eats[zooArr[i]].Contains(zooArr[i+1]))
            {
                theZoo.Add(zooArr[i] + " eats " + zooArr[i+1]);
                zooArr = zooArr.RemoveAt(i+1);
                break;
            }     
        }  
    } 
    theZoo.Add(String.Join(",", zooArr));
    string[] convert = new string[theZoo.Count()];
    counter = 0;
    foreach(var za in theZoo)
    {
        convert[counter] = za;
        counter++;
    }
    return convert;
  }
}
  
public static class ExtMethod
{
  public static T[] RemoveAt<T>(this T[] source, int index)
  {
      T[] dest = new T[source.Length - 1];
      if( index > 0 )
          Array.Copy(source, 0, dest, 0, index);
  
      if( index < source.Length - 1 )
          Array.Copy(source, index + 1, dest, index, source.Length - index - 1);
  
      return dest;
  }    
}