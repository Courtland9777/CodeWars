using System;
using System.Collections.Generic;
using System.Linq;

public static class Ext
{
    public static TimeSpan Average(this IEnumerable<TimeSpan> timeSpans)
    {
        IEnumerable<long> ticksPerTimeSpan = timeSpans.Select(t => t.Ticks);
        double averageTicks = ticksPerTimeSpan.Average();
        long averageTicksLong = Convert.ToInt64(averageTicks);

        return TimeSpan.FromTicks(averageTicksLong);
    }
}
public class Stat
{   
    public static string stat(string strg)
    {
      if (strg.Length == 0) return "";
      var ts = strg.Split(',').Select(t => TimeSpan.Parse(t.Replace('|', ':'))).OrderBy(n => n).ToList();
      var median = ts.Count % 2 == 0
          ? (Ext.Average(new TimeSpan[] { ts[(ts.Count / 2) - 1], ts[ts.Count / 2] })) : ts[(ts.Count / 2)];
      return $"Range: {ts[ts.Count - 1] - ts[0]:hh\\|mm\\|ss} Average: {Ext.Average(ts):hh\\|mm\\|ss} Median: {median:hh\\|mm\\|ss}";
    }
}