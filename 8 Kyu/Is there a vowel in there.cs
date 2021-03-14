using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static object[] IsVow(object[] a)
  {
    for (int i = 0; i < a.Length; i++)
    {
        if ((int)a[i] == 'a' || (int)a[i] == 'e' || (int)a[i] == 'i' || (int)a[i] == 'o' || (int)a[i] == 'u')
        {
            a[i] = Convert.ToChar(a[i]).ToString();
        }
    }
    return a;
  }
}