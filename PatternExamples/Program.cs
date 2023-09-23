using FactoryMethod;
using AbstractFactory;
using Facade.Facades;

internal class Program
{
    private static void Main(string[] args)
    {
        ///START


        ///Factory method
        Console.WriteLine("\nFACTORY METHOD");

        FactoryMethod.Main factoryMethod = new FactoryMethod.Main();

        factoryMethod.MainMethod();

        ///Abstract factory
        Console.WriteLine("\nABSTRACT FACTORY");

        AbstractFactory.Main abstractFactory = new AbstractFactory.Main();

        abstractFactory.MainMethod();

        ///Builder

        Console.WriteLine("\nBUILDER");

        Builder.Main builder = new Builder.Main();

        builder.MainMethod();

        ///Facade

        Console.WriteLine("\nFACADE");

        Facade.Main facade = new Facade.Main(new ShoppingFacade());

        facade.MainMethod();

        ///END
        Console.ReadKey();
    }
}