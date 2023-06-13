namespace PetUniverse;

class Dog : Pet
{
    public string Breed { get; private set; }
    public Dog(string name, string breed) : base (name)
    {
        Breed = breed;
    }
    public override string Speak()
    {
        return "Bark!";
    }
    public override bool Eat(string food)
    {
        if (food == "Chicken")
        {
            Love += 5;
            return true;
        }
        else
        {
            return false;
        }
    }
    public override int Cuddle()
    {
        Love *= 10;
        return Love;
    }
}