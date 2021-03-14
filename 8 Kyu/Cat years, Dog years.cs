public class Dinglemouse {

  public static int[] humanYearsCatYearsDogYears(int humanYears) {
    if(humanYears == 0) return new int[] { 0, 0, 0 };
    int cy = 15;
    int dy = 15;
    if (humanYears == 1) return new int[] { 1, cy, dy };
    cy += 9;
    dy += 9;
    if (humanYears == 2) return new int[] { 2, cy, dy };
    for (int i = 3; i <= humanYears; i++)
    {
        cy += 4;
        dy += 5;
    }
    return new int[] { humanYears, cy, dy };
  }

}