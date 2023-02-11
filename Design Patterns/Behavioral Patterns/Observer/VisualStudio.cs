namespace Design_Patterns.Behavioral_Patterns.Observer;

//Concrete Subject
public class VisualStudio : Microsoft
{
    public VisualStudio(string nameProduct, decimal versionProduct) : base(nameProduct, versionProduct)
    {
    }
}

