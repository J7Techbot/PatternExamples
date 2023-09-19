using AbstractFactory.Components;
using AbstractFactory.Components.Windows;

namespace AbstractFactory.Factory
{
    public class WindowsComponentFactory : BaseComponentFactory
    {
        public override BaseButton CreateButton()
        {
            return new WinButton();
        }

        public override BaseCheckBox CreateCheckbox()
        {
            return new WinCheckbox();
        }

        public override BaseInputField CreateInputField()
        {
            return new WinInputField();
        }
    }
}
