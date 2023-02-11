namespace Design_Patterns.Structural_Patterns.Adapter;

//Target class
public class RabbitMq : IQueue
{
    public void Publish()
    {
        Console.WriteLine("Publicando mensagem com RabbitMq");
    }

    public void Subscribe()
    {
        Console.WriteLine("Lendo mensagem com RabbitMq");
    }
}

