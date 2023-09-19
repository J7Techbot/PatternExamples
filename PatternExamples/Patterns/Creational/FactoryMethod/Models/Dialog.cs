using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    internal abstract class Dialog
    {
        public abstract IButton CreateButton();

        public void Render()
        {
            IButton okButton = CreateButton();

            okButton.OnClick();
            okButton.Render();
        }
    }
}
