using System;

public static class AgeDiff 
{
  public static string CalculateAge(int birth, int yearTo) 
  {
    if(yearTo-birth == 0) return "You were born this very year!";
    if(yearTo-birth == -1) return "You will be born in 1 year.";
    if(yearTo-birth < -2) return $"You will be born in {Math.Abs(yearTo-birth)} years.";
    return yearTo-birth == 1 ? $"You are {yearTo-birth} year old." : $"You are {yearTo-birth} years old.";
  }
}