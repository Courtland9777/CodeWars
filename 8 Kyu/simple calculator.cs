using System;
public class Kata
{
  public static double Calculator(double a, double b, char op)
  {
      switch (op)
      {
          case '+':
              return a + b;
          case '-':
              return a - b;
          case '*':
              return a * b;
          case '/':
              return b != 0 ? a / b : throw new DivideByZeroException("b can not equal 0.");
          default:
              throw new ArgumentException("Invalid Input");
      }
  }
}