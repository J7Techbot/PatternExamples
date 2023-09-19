using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.Patterns.Creational.FactoryMethod.Interfaces
{
    internal interface IButton
    {
        public void Render();
        public void OnClick();
    }
}
