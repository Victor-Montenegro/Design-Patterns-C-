namespace Design_Patterns.Creational_Patterns.AbstractFactory;

//Concrete Factory 1
public class SnackConcrectFactory1 : SnackAbstractFactory
{
    public override AbstractDrink CreateDrink()
    {
        return new Coffee();
    }

    public override AbstractSandwich CreateSandwich()
    {
        return new CheeseSandwich();
    }
}
