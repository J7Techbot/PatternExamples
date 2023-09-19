using PatternExamples.Patterns.Creational.FactoryMethod.Interfaces;

namespace PatternExamples.Patterns.Creational.FactoryMethod.Models
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
