using AbstractFactory.Components;
using AbstractFactory.Components.Linux;

namespace AbstractFactory.Factory
{
    public class LinuxComponentFactory : BaseComponentFactory
    {
        public override BaseButton CreateButton()
        {
            return new LinuxButton();
        }

        public override BaseCheckBox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }

        public override BaseInputField CreateInputField()
        {
            return new LinuxInputField();
        }
    }
}
