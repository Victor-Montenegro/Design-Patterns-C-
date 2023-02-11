namespace Design_Patterns.Creational_Patterns.Factory_Method;
public class AnimalConcreteFactory : AnimalFactoryMethod
{
    public override Animal CreateAnimal(TypeAnimal typeAnimal)
    {
        switch (typeAnimal)
        {
            case TypeAnimal.Dog: return new Dog("Dog");
            case TypeAnimal.Cat: return new Cat("Cat");
            default: return null;
        }
    }
}

