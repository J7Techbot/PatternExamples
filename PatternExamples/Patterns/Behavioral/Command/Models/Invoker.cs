using Command.Interfaces;

namespace Command.Models
{
    internal class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public void Run()
        {
            /// some logic...
            _command.Execute();
        }
    }
}
