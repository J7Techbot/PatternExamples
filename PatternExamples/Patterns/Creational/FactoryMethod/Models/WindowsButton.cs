using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    internal class WindowsButton : IButton
    {
        public void OnClick()
        {
            //some func
        }

        public void Render()
        {
            Console.WriteLine("WindowsButton rendered");
        }
    }
}
