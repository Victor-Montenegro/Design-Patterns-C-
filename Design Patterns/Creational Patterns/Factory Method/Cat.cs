namespace Design_Patterns.Creational_Patterns.Factory_Method;
public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override string Som()
    {
        return $"{Name}: Miau";
    }
}

