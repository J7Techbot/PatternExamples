using Composite.Interfaces;

namespace Composite.Models
{
    //leaf
    public class Data : IComponent
    {
        public void Operate()
        {
            Console.WriteLine("Process data");
        }
    }
}
