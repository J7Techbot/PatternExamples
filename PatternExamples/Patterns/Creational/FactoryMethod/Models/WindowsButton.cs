using PatternExamples.Patterns.Creational.FactoryMethod.Interfaces;

namespace PatternExamples.Patterns.Creational.FactoryMethod.Models
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
