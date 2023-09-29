using Command.Commands;
using Command.Models;

namespace Command
{
    internal class Main
    {
        public void MainMethod()
        {
            Receiver receiver = new Receiver();
            Invoker invoker = new Invoker();

            Console.WriteLine("Simple command");
            invoker.SetCommand(new SimpleCommand("Running Simple command"));
            invoker.Run();

            Console.WriteLine("\nComplex command");
            invoker.SetCommand(new ComplexCommand(receiver, "RunFunc1", "RunFunc2"));
            invoker.Run();

        }
    }
}
