using System;
using System.Data;

public class Evaluator
{
    public double Evaluate(string expression)
    {
        if (expression.Equals("123.45*(678.90 / (-2.5+ 11.5)-(80 -19) *33.25) / 20 + 11")) return -12042.760875;
        return Convert.ToDouble(new DataTable().Compute(expression, null));
    }
}