using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
	public static List<int> Unique(List<int> integers) => integers.Distinct().ToList();
}