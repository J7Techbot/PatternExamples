using PatternExamples.Patterns.FactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        PatternExamples.Patterns.FactoryMethod.Main factoryMethod = new Main();

        factoryMethod.MainMethod();

        Console.ReadKey();
    }
}