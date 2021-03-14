using System.Linq;
public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Gender;

    public Person(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male")
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Gender = gender;
    }

    public string SayFullName()
    {
        return $"{FirstName} {LastName}";
    }
    
    public static string GreetExtraTerrestrials(string raceName)
    {
        return $"Welcome to Planet Earth {raceName}";
    }
}