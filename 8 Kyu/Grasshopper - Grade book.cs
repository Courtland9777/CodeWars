using System;

public class Kata
{
  public static char GetGrade(int s1, int s2, int s3)
  {
    int score = (s1 + s2 + s3) / 3;
    return score < 60 ? 'F' : score < 70 ? 'D' : score < 80 ? 'C' : score < 90 ? 'B' : 'A';
  }
}