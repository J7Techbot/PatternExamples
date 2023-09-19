using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    internal class LinuxDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new LinuxButton();
        }
    }
}
