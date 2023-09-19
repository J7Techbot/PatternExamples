using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    internal class LinuxButton : IButton
    {
        public void OnClick()
        {
            //some func
        }

        public void Render()
        {
            Console.WriteLine("LinuxBUtton rendered");
        }
    }
}
