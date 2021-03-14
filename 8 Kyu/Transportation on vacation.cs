public class RentalCar {
    
    public static int RentalCarCost(int d) {
        if (d < 3) return 40 * d;
        else if (d > 2 && d < 7) return (40 * d) - 20;
        else return (40 * d) - 50;
    }
}