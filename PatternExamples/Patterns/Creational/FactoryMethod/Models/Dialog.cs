using PatternExamples.Patterns.Creational.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.Patterns.Creational.FactoryMethod.Models
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
