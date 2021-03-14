using System;

public static class Time
{
  public static string Correct(string ts)
  { 
    if (ts == null) return null;
    if (ts.Equals("")) return string.Empty;
    if (ts.Length < 8 || !char.IsDigit(ts[0]) || !char.IsDigit(ts[1]) || !char.IsDigit(ts[3]) || !char.IsDigit(ts[4]) || !char.IsDigit(ts[6]) || !char.IsDigit(ts[7]) ||
        !ts[2].Equals(':') || !ts[5].Equals(':')) { return null; }
    int hour = int.Parse(ts.Substring(0, 2));
    int min = int.Parse(ts.Substring(3, 2));
    int sec = int.Parse(ts.Substring(6, 2));
    if(sec > 59)
    {
        int counter = 0;
        do
        {
            sec -= 60;
            counter++;
        } while (sec > 59);
        min += counter;
    }
    if (min > 59)
    {
        int counter = 0;
        do
        {
            min -= 60;
            counter++;
        } while (sec > 59);
        hour += counter;
    }
    if (hour > 24)
    {
        hour %= 24;
    }
    if (hour == 24 && (min > 0 || sec > 0)) { hour = 0; }
    string hr = hour < 10 ? $"0{hour}" : hour.ToString();
    string mn = min < 10 ? $"0{min}" : min.ToString();
    string sc = sec < 10 ? $"0{sec}" : sec.ToString();
    return $"{hr}:{mn}:{sc}";
  }
}