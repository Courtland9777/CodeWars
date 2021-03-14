public class Person
{
    public string Info { get; set; }
    
    public Person(string name, int age)
    {
        Info = $"{name}s age is {age}";
    }
}
