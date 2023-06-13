namespace PetUniverse;

class Dog : Pet
{
    public string FurColor { get; private set; }
    public Dog(string name, string furColor) : base (name)
    {
        FurColor = furColor;
    }
    public override string Speak()
    {
        return "Bark!";
    }
    public override bool Eat(string food)
    {
        if (food == "Chicken")
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
        return Love *= 10;
    }
}