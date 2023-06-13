namespace PetUniverse;
public abstract class Pet
{
    public string Name { get; private set; }
    public int Love { get; private set; } = 0;
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
    public abstract bool Eat();
    public abstract int Cuddle();
}
