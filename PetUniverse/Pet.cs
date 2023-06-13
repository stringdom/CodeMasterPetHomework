namespace PetUniverse;
public abstract class Pet
{
    public string Name { get; private set; }
    public int Love { get; set; } = 0;
    public Pet(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            Name = "Invalid Name";
        }
        else
        {
            Name = name;
        }
    }
    public abstract string Speak();
    public abstract bool Eat(string food);
    public abstract int Cuddle();
}

public class Menagerie
{
    public List<Pet> List { get; set; }
    public Menagerie()
    {
        List = new List<Pet>();
    }
}