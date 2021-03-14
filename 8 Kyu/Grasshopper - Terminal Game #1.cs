public class Hero
{
    public string Name { get; set; }
    public string Position { get; set; }
    public float Health { get; set; }
    public float Damage { get; set; }
    public int Experience { get; set; }

    public Hero(string name = "Hero")
    {
        Name = name;
        Position = "00";
        Health = 100;
        Damage = 5;
        Experience = 0;
    }
}