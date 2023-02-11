namespace Design_Patterns.Creational_Patterns.AbstractFactory;

// Abstract Factory
public abstract class SnackAbstractFactory
{
    public abstract AbstractSandwich CreateSandwich();
    public abstract AbstractDrink CreateDrink();
}

