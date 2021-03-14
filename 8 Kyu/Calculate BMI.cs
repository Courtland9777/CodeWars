using System;
public class Kata
{
  public static string Bmi(double weight, double height)
  {
    double bmi = weight / Math.Pow(height, 2);
    return bmi > 30 ? "Obese" : bmi <= 18.5 ? "Underweight" : bmi <= 25 ? "Normal" : "Overweight";
  }
}