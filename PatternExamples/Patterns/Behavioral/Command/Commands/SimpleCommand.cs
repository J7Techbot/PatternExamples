using Command.Interfaces;

namespace Command.Commands
{
    internal class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: {this._payload}");
        }
    }
}
