namespace Design_Patterns.Behavioral_Patterns.Observer;

//Observer
public abstract class Observer
{
    protected Observer(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public abstract void UpdateNotify(Microsoft microsoft);
}

