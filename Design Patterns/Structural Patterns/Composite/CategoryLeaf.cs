namespace Design_Patterns.Structural_Patterns.Composite;

//Leaf
public class CategoryLeaf : CategoryBase
{
    public CategoryLeaf(string name) : base(name)
    {
    }

    public override void Add(CategoryBase category)
    {
        Console.WriteLine("Não possui childrens");
    }

    public override void Exibir(int count)
    {
        Console.WriteLine($"{new string('*', count)} {this.name}");
    }

    public override void Remove(CategoryBase category)
    {
        Console.WriteLine("Não possui childrens");
    }
}

