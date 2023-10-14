using Adapter.Interfaces;
using Adapter.Services;
using System.Xml.Linq;

namespace Adapter.Adapters
{
    /// <summary>
    /// Adapter transforms data from json to xml
    /// </summary>
    internal class JsonServiceAdapter : IServiceAdapter
    {
        JsonService _jsonService;

        public JsonServiceAdapter(JsonService jsonService)
        {
            _jsonService = jsonService;
        }

        public XDocument GetRequest()
        {
            XDocument parsedJsonDocument = new XDocument();

            string akaJson = _jsonService.GetJSONRequest();

            parsedJsonDocument.Add(new XElement("type", akaJson));

            return parsedJsonDocument;
        }
    }
}
