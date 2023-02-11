namespace Design_Patterns.Creational_Patterns.Factory_Method;

//Product Abstract
public abstract class Animal
{
    public Animal(string name) 
    {
        Name = name;
    }
   protected string Name { get; set; }
   public abstract string Som();
}

