using AbstractFactory.Components;
using AbstractFactory.Factory;

//wrong
using AbstractFactory.Components.Linux;
using AbstractFactory.Components.Windows;
//

namespace AbstractFactory
{
    public class Main
    {
        BaseComponentFactory _componentFactory;

        BaseButton button;

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
            button = _componentFactory.CreateButton();

            button.OnClick();
        }

        public void OnClickCommand()
        {
            button.OnClick();
        }
    }

    internal class Wrong
    {
        WinButton winButton;
        LinuxButton linuxButton;
        public void MainMethod()
        {
            PlatformID platform = Environment.OSVersion.Platform;

            if (platform == PlatformID.Win32NT)
            {
                winButton = new WinButton();

                winButton.OnClick();
            }
            else if (platform == PlatformID.Unix)
            {
                linuxButton = new LinuxButton();

                linuxButton.OnClick();
            }
        }

        public void OnClickCommand()
        {
            if (winButton != null)
                winButton.OnClick();
            else if (linuxButton != null)
                linuxButton.OnClick();
        }
    }
}
