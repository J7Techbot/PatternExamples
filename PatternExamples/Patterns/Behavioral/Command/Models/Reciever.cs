namespace Command.Models
{
    internal class Receiver
    {
        public void RunFunc1(string a)
        {
            Console.WriteLine($"Receiver: {a}");
        }

        public void RunFunc2(string b)
        {
            Console.WriteLine($"Receiver: {b}");
        }
    }
}
