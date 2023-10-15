using Composite.Interfaces;

namespace Composite.Models
{
    //leaf
    public class Attribute : IComponent
    {
        public void Operate()
        {
            Console.WriteLine("Process attribute");
        }
    }
}
