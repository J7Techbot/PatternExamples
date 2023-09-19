using FactoryMethod;
using AbstractFactory;

internal class Program
{
    private static void Main(string[] args)
    {
        ///START
        

        ///Factory method
        FactoryMethod.Main factoryMethod = new FactoryMethod.Main();

        factoryMethod.MainMethod();

        ///Abstract factory
        AbstractFactory.Main abstractFactory = new AbstractFactory.Main();

        abstractFactory.MainMethod();


        ///END
        Console.ReadKey();
    }
}