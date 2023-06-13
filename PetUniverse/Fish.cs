namespace PetUniverse;
public class Fish : Pet
{
    public Fish(string name) : base(name) { }
    public override string Speak()  
    {
        return "Glug";
    }
    public override bool Eat(string food)
    {
        if (food == "Fish food")
        {
            Love += 10;
            return true;
        }
        else
        {
            return false;
        }
    }
    public override int Cuddle()
    {
        Love -= 100;
        return Love;
    }
}
