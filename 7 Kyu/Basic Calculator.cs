using System;

public static class Calculator
{
  public static double Execute(double num1, char op, double num2)
  {
    switch (op)
    {
        case '+':
            return num1 + num2;
        case '-':
            return num1 - num2;
        case '*':
            return num1 * num2;
        case '/':
            return (double.IsInfinity(num2) || num2 == 0) ? throw new System.ArgumentException("Denominatior can not be zero", "num2") : num1 / num2;
        default:
            throw new System.ArgumentException("Parameter must be +, -, * or /.", "op");
    }
  }
}