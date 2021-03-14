public abstract class Human
{

}

public class Man : Human
{

}

public class Woman : Human
{

}
public class God
{
  public static Human[] Create()
  {
    return new Human[2] {new Man(),new Woman()};
  }
}