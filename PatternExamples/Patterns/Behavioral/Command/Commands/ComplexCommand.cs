using Command.Interfaces;
using Command.Models;

namespace Command.Commands
{
    internal class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        private string _a;

        private string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        public void Execute()
        {
            this._receiver.RunFunc1(this._a);
            this._receiver.RunFunc2(this._b);
        }
    }
}
