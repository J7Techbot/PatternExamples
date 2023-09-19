using PatternExamples.Patterns.Creational.FactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Main factoryMethod = new Main();

        factoryMethod.MainMethod();

        Console.ReadKey();
    }
}