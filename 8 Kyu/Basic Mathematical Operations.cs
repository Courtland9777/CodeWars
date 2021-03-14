namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
      if (operation == '/' && value2 == 0) {return -1;}
      
      double result = 0;
      if (operation == '+')
        result = value1 + value2;
      else if (operation == '-')
        result = value1 - value2;
      else if (operation == '*')
        result = value1 * value2;
      else if (operation == '/')
        result = value1 / value2;
      else
        return -1;
      return result;
    }
  }
}