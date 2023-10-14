using System.Xml.Linq;

namespace Adapter.Interfaces
{
    internal interface IServiceAdapter
    {
        public XDocument GetRequest();
    }
}
