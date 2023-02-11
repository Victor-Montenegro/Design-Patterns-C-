namespace Design_Patterns.Creational_Patterns.Singleton;
public sealed class ServiceFileStorage
{
    public static ServiceFileStorage _instance = new ServiceFileStorage();
    private ServiceFileStorage()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; }

    public static ServiceFileStorage GetInstance()
    {
        if (_instance is null) _instance = new ServiceFileStorage();

        return _instance;
    }
}

