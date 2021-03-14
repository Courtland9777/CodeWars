public class Evaporator { 
  
  public static int evaporator(double content, double evap_per_day, double threshold) {
    int counter = 0;
    double currentContent = (double) content;
    do
    {
        currentContent *= (1 - (evap_per_day / 100));
        counter++;
    } while (currentContent > content * (threshold/100));

    return counter;
  }
}