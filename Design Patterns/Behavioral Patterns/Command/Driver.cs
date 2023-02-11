namespace Design_Patterns.Behavioral_Patterns.Command;

//Receiver
public class Driver
{
    public void PickUpPassenger()
    {
        Console.WriteLine("Looking for passenger");
    }

    public void Leavingpassenger() 
    {
        Console.WriteLine("Leaving the passenger");
    }
}

