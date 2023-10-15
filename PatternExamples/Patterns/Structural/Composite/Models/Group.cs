using Composite.Interfaces;

namespace Composite.Models
{
    //composite
    public class Group : IComponent
    {
        List<IComponent> _composites = new List<IComponent>();
        public void Operate()
        {
            foreach (var composite in _composites)
            {
                composite.Operate();
            }
        }
        public void Add(IComponent composite)
        {
            _composites.Add(composite);
        }
    }
}
