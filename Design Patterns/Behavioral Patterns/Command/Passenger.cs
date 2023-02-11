namespace Design_Patterns.Behavioral_Patterns.Command
{
    //Client
    public class Passenger
    {
        private readonly Driver _driver = new Driver();

        public void RequestTrip()
        {
            Command command = new UberCommand(_driver);

            command.Travel();
        }
    }
}
