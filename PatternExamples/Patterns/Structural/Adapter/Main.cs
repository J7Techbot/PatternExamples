using Adapter.Adapters;
using Adapter.Interfaces;
using Adapter.Services;

namespace Adapter
{
    internal class Main
    {
        XmlProcessor _Xmlprocessor;
        XMLService _xmlservice;
        JsonService _jsonservice;

        public Main()
        {
            _Xmlprocessor = new XmlProcessor();
            _xmlservice = new XMLService();
            _jsonservice = new JsonService();
        }

        public void MainMethod()
        {
            ///xml processor process data from xml service
            _Xmlprocessor.ProcessData(_xmlservice.GetXMLRequest());

            IServiceAdapter adapter = new JsonServiceAdapter(_jsonservice);

            ///xml processor process data from json service with adapter
            _Xmlprocessor.ProcessData(adapter.GetRequest());
        }
    }
}
