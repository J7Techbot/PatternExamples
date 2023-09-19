using PatternExamples.Patterns.FactoryMethod.Interfaces;
namespace PatternExamples.Patterns.FactoryMethod.Models
{
    internal class LinuxDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new LinuxButton();
        }
    }
}
