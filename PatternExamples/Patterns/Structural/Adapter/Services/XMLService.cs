using System.Xml.Linq;

namespace Adapter.Services
{
    internal class XMLService 
    {
        public XDocument GetXMLRequest()
        {
            //Get XML document from service...
            XDocument newDocument = new XDocument();

            newDocument.Add(new XElement("type","XML service response"));

            return newDocument;
        }
    }
}
