using System;

public class Kata 
{
  public static double Arithmetic(double a, double b, string op) 
  {
    switch (op)
            {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    return b != 0 ? a / b : 0;
                default:
                    return 0;
            }
  }
}