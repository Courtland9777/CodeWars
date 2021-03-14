using System;
using System.Globalization;

public class Kata
{
  public static string TitleCase(string title, string minorWords = "")
  {
    if(minorWords==null) minorWords = "";
    TextInfo ti = new CultureInfo("en-US", false).TextInfo;
    string[] minWords = minorWords.ToLower().Split(' ');
    string[] arrTitle = ti.ToTitleCase(title.ToLower()).Split(' ');
    for (int i = 1; i < arrTitle.Length; i++)
    {
        for (int j = 0; j < minWords.Length; j++)
        {
            if (minWords[j].Equals(arrTitle[i].ToLower())) arrTitle[i] = arrTitle[i].ToLower().ToString();
                
        }
    }
    return String.Join(" ", arrTitle);
  }
}