using Adapter.Interfaces;
using System.Xml.Linq;

namespace Adapter.Services
{
    internal class XmlProcessor
    {
        public void ProcessData(XDocument document)
        {
            ///process data
            Console.WriteLine(document.Root);
        }

        public void ProcessData(IServiceAdapter service)
        {
            XDocument document = service.GetRequest();

            ///process data
            Console.WriteLine(document);
        }
    }
}
