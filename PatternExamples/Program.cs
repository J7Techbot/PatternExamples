using FactoryMethod;
using AbstractFactory;
using Facade.Facades;

internal class Program
{
    private static void Main(string[] args)
    {
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

        ///Iterator

        Console.WriteLine("\nITERATOR");

        Iterator.Main iterator = new Iterator.Main();

        iterator.MainMethod();

        ///Observer

        Console.WriteLine("\nOBSERVER");

        Observer.Main observer = new Observer.Main();

        observer.MainMethod();

        ///Command

        Console.WriteLine("\nCOMMAND");

        Command.Main command = new Command.Main();

        command.MainMethod();        

        ///Adapter

        Console.WriteLine("\nADAPTER");

        Adapter.Main adapter = new Adapter.Main();

        adapter.MainMethod();

        Console.ReadKey();
    }
}