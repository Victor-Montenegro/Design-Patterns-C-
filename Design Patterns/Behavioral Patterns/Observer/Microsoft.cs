namespace Design_Patterns.Behavioral_Patterns.Observer;
//Subject
public class Microsoft
{
    private List<Observer> _observers = new List<Observer>();
    private decimal _version;
    public string NameProduct { get; set; }
    public decimal VersionProduct
    {
        get => _version;

        set
        {
            if (_version != value)
            {
                _version = value;
                Notify();
            }
        }
    }

    public Microsoft(string nameProduct, decimal versionProduct)
    {
        NameProduct = nameProduct;
        _version = versionProduct;
    }

    public void AddObserver(Observer observer)
    {
        _observers.Add(observer);
        Console.WriteLine($"{observer.Name} Adicionado");
    }

    public void RemoveObserver(Observer observer)
    {
        _observers.Remove(observer);
        Console.WriteLine($"{observer.Name} Removido");
    }

    private void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.UpdateNotify(this);
        }
    }

}

