namespace Design_Patterns.Creational_Patterns.Factory_Method;
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override string Som()
    {
        return $"{Name}: Auauau";
    }
}

