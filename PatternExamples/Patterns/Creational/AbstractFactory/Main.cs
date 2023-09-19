using AbstractFactory.Components;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    public class Main
    {
        BaseComponentFactory _componentFactory;

        public Main()
        {
            PlatformID platform = Environment.OSVersion.Platform;

            if (platform == PlatformID.Win32NT)
            {
                _componentFactory = new WindowsComponentFactory();
            }
            else if (platform == PlatformID.Unix)
            {
                _componentFactory = new LinuxComponentFactory();
            }
        }

        public void MainMethod()
        {            
            BaseButton button = _componentFactory.CreateButton();

            button.OnClick();
        }
    }
}
