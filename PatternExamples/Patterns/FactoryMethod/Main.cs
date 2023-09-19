using PatternExamples.Patterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.Patterns.FactoryMethod
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
