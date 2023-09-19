using FactoryMethod.Models;

namespace FactoryMethod
{
    internal class Main
    {
        Dialog _dialog;

        public Main()
        {
            PlatformID platform = Environment.OSVersion.Platform;

            if (platform == PlatformID.Win32NT)
            {
                _dialog = new WindowsDialog();
            }
            else if (platform == PlatformID.Unix)
            {
                _dialog = new LinuxDialog();
            }

        }

        public void MainMethod()
        {
            _dialog.Render();
        }
    }
}
