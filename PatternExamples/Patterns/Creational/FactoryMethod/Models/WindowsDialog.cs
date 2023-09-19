using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    internal class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
