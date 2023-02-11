using Design_Patterns.Behavioral_Patterns.Command;
using Design_Patterns.Behavioral_Patterns.Observer;
using Design_Patterns.Behavioral_Patterns.Strategy;
using Design_Patterns.Creational_Patterns.AbstractFactory;
using Design_Patterns.Creational_Patterns.Factory_Method;
using Design_Patterns.Creational_Patterns.Singleton;
using Design_Patterns.Structural_Patterns.Adapter;
using Design_Patterns.Structural_Patterns.Composite;
using Design_Patterns.Structural_Patterns.Facade;

namespace Design_Patterns;
public class Program
{
    public static void Main(string[] args)
    {
        //AbstractFactory();
        //FactoryMethod();
        //Singleton();
        //Adapter();
        //Facade();
        //Composite();
        //Command();
        //Strategy();
        Observer();
    }

    public static void AbstractFactory()
    {
        var client1 = new Client(new SnackConcrectFactory1());
        client1.Run();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        var client2 = new Client(new SnackConcrectFactory2());
        client2.Run();
    }

    public static void FactoryMethod()
    {
        var concreteFactory = new AnimalConcreteFactory();

        var animale1 = concreteFactory.CreateAnimal(TypeAnimal.Dog);

        Console.WriteLine(animale1.Som());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        var animale2 = concreteFactory.CreateAnimal(TypeAnimal.Cat);
        Console.WriteLine(animale2.Som());
    }

    public static void Singleton()
    {
        var serviceFileStorage1 = ServiceFileStorage._instance;

        var serviceFileStorage2 = ServiceFileStorage._instance;

        if (serviceFileStorage1 == serviceFileStorage2)
            Console.WriteLine("Have the same instance");

        Console.WriteLine(serviceFileStorage1.Id);
        Console.WriteLine(serviceFileStorage2.Id);
    }

    public static void Adapter()
    {
        var paymentService = new PaymentService(new QueueAdapter(new IbmMq()));

        paymentService.CompleteCard();
    }

    public static void Facade()
    {
        var ticketService = new TicketService(new FileStorageService(new GoogleStorage()));

        ticketService.Create();
    }

    public static void Composite()
    {

        var categoryRoot = new CategoryComposite("categoryRoot");
        var categoryNv1 = new CategoryComposite("categoryNv1");
        var categoryNv2 = new CategoryLeaf("categoryNv2");
        var categoryNv3 = new CategoryLeaf("categoryNv3");

        categoryRoot.Add(categoryNv1);
        categoryRoot.Add(categoryNv2);
        categoryRoot.Add(categoryNv3);


        var categoryNv1_1 = new CategoryComposite("categoryNv1_1");
        var categoryNv1_2 = new CategoryComposite("categoryNv1_2");
        var categoryNv1_3 = new CategoryComposite("categoryNv1_3");

        categoryNv1.Add(categoryNv1_1);
        categoryNv1.Add(categoryNv1_2);
        categoryNv1.Add(categoryNv1_3);

        categoryRoot.Exibir(2);
    }

    public static void Command()
    {
        var passenger = new Passenger();

        passenger.RequestTrip();
    }

    public static void Strategy()
    {
        var fileName = "Gastos_Mensais_2022";
        var typeExport = TypeExport.Pdf;

        var context = new ExportContext(ExportFactory.CreateExport(typeExport));

        context.ExportFile(fileName);
    }

    public static void Observer()
    {
        var vs = new VisualStudio("Visual Studio Community", 1);

        var client1 = new Developer("Lucas");
        var client2 = new Developer("João");
        var client3 = new Developer("Pedro");

        vs.AddObserver(client1);
        vs.AddObserver(client2);
        vs.AddObserver(client3);

        vs.VersionProduct = 2;
    }

}
