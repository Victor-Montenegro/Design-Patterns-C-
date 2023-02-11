namespace Design_Patterns.Creational_Patterns.AbstractFactory;

//Concrete Factory 2
public class SnackConcrectFactory2 : SnackAbstractFactory
{
    public override AbstractDrink CreateDrink()
    {
        return new Refrigerator();
    }

    public override AbstractSandwich CreateSandwich()
    {
        return new HamSandwich();
    }
}
