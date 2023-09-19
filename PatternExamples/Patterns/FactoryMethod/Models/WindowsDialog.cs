using PatternExamples.Patterns.FactoryMethod.Interfaces;
namespace PatternExamples.Patterns.FactoryMethod.Models
{
    internal class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
