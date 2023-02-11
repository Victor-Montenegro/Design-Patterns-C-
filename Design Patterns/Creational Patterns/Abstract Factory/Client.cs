namespace Design_Patterns.Creational_Patterns.AbstractFactory;
public class Client
{
    private AbstractDrink _drink;
    private AbstractSandwich _sandwich;

    public Client(SnackAbstractFactory abstractFactory)
    {
        _drink = abstractFactory.CreateDrink();
        _sandwich = abstractFactory.CreateSandwich();
    }

    public void Run()
    {
        Console.WriteLine($"Meu lanche: {_drink.Output()} com {_sandwich.Output()}");
    }


}

