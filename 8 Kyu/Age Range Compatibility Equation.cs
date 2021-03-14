using System;
public class Kata
{
  public static string DatingRange(int age) =>
    age < 15 ? $"{Math.Floor(age - (0.10 * age))}-{Math.Floor(age + (0.10 * age))}" : 
               $"{Math.Floor(0.5 * age) + 7}-{Math.Floor((age - 7) / 0.5)}";
}