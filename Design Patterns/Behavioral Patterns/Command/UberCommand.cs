namespace Design_Patterns.Behavioral_Patterns.Command;

//Concrete Command
public class UberCommand : Command
{

    private readonly Driver _driver;

    public UberCommand(Driver driver)
    {
        _driver = driver;
    }

    public override void Travel()
    {
        _driver.PickUpPassenger();
        _driver.Leavingpassenger();
    }
}

