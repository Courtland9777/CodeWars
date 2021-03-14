using System;

public class Diamond
{
  public static string print(int n)
  {
    if (n < 1 || n % 2 == 0) return null;
    if (n == 1) return "*\n";
    string newLine = "\n";
    string diamond = "";
    int spacer = 0;

    for (int i = 1; i <= n; i += 2)
    {
        spacer = (n - i) / 2;
        while (spacer > 0)
        {
            diamond += " ";
            spacer--;
        }
        for (int j = 0; j < i; j++)
        {
            diamond += "*";
        }
        diamond += newLine;
    }

    for (int p = n - 2; p > 0; p -= 2)
    {
        spacer = (n - p) / 2;
        while (spacer > 0)
        {
            diamond += " ";
            spacer--;
        }
        for (int j = 0; j < p; j++)
        {
            diamond += "*";
        }
        diamond += newLine;
    }
    return diamond;
  }
}