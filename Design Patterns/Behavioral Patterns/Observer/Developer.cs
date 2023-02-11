namespace Design_Patterns.Behavioral_Patterns.Observer;
//Concrete Observer
public class Developer : Observer
{
    public Developer(string name) : base(name)
    {
    }

    public override void UpdateNotify(Microsoft microsoft)
    {
        Console.WriteLine($"{this.Name} você possui uma nova versão do {microsoft.NameProduct} v{microsoft.VersionProduct}");
    }
}

