using System.Collections.Generic;
public class Kata
{
  public static string GetDrinkByProfession(string p)
  {
    var dict = new Dictionary<string,string>
    {
        { "jabroni", "Patron Tequila" },
        { "school counselor", "Anything with Alcohol" },
        { "programmer", "Hipster Craft Beer" },
        { "bike gang member", "Moonshine" },
        { "politician", "Your tax dollars" },
        { "rapper", "Cristal" }
    };

    return dict.ContainsKey(p.ToLower()) ? dict[p.ToLower()] : "Beer";
  }
}