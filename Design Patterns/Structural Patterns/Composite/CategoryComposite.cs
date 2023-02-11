namespace Design_Patterns.Structural_Patterns.Composite;

//Composite
public class CategoryComposite : CategoryBase
{
    List<CategoryBase> _categories = new List<CategoryBase>();

    public CategoryComposite(string name) : base(name)
    {

    }

    public override void Add(CategoryBase category)
    {
        _categories.Add(category);
    }

    public override void Exibir(int count)
    {
        Console.WriteLine($"{new string('*', count)} {this.name}");

        foreach (var child in _categories)
        {
            child.Exibir(count + count);
        }
    }

    public override void Remove(CategoryBase category)
    {
        _categories.Remove(category);
    }
}

