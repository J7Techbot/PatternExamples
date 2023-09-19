using PatternExamples.Patterns.Creational.FactoryMethod.Interfaces;

namespace PatternExamples.Patterns.Creational.FactoryMethod.Models
{
    internal class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
