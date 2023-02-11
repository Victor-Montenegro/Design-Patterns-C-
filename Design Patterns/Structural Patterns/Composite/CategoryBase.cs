namespace Design_Patterns.Structural_Patterns.Composite;

//Component
public abstract class CategoryBase
{
    protected string name;

    protected CategoryBase(string name)
    {
        this.name = name;
    }

    public abstract void Add(CategoryBase category);
    public abstract void Remove(CategoryBase category);
    public abstract void Exibir(int count);
}

