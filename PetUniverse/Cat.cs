namespace PetUniverse;
public class Cat : Pet
{
    public string FurColor { get; private set; }
    public Cat(string name, string color) : base(name)
    {
        FurColor = color;
    }
    public override string Speak()
    {
        return "Meow!";
    }
    public override bool Eat(string food)
    {
        if (food == "Fish")
        {
            Love += 1;
            return true;
        }
        else
        {
            return false;
        }
    }
    public override int Cuddle()
    {
        Love *= 2;
        return Love;
    }
}
