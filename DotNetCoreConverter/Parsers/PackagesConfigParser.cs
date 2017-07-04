using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace DotNetCoreConverter.Parsers
{
    public class PackagesConfigParser : Parser
    {
        private XDocument _content;
        
        public PackagesConfigParser(string path)
        {
            _content = XDocument.Load(path);
        }

        private IEnumerable<string> ExtractValue(string elementName)
        {
            return ExtractElement(elementName).Select(i => i.Value);
        }

        private IEnumerable<string> ExtractAttribute(string elementName, string attributeName)
        {
            return _content.Descendants(elementName).Select(i => i.Attribute(attributeName)).Select(i => i.Value);
        }

        private IEnumerable<XElement> ExtractElement(string elementName)
        {
            return _content.Descendants(elementName);
        }

        public IEnumerable<XElement> GetPackageReferences()
        {
            return ExtractElement("package");
        }
    }
}