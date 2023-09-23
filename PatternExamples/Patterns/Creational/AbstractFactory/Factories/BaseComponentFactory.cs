using AbstractFactory.Components;

namespace AbstractFactory.Factory
{
    public abstract class BaseComponentFactory
    {
        public abstract BaseCheckBox CreateCheckbox();
        public abstract BaseInputField CreateInputField();
        public abstract BaseButton CreateButton();
    }
}
