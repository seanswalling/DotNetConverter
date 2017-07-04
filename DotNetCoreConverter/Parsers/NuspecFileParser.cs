using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DotNetCoreConverter.Parsers
{
    public class NuspecFileParser : Parser
    {
        private XDocument _content;

        public NuspecFileParser(string path)
        {
            _content = XDocument.Load(path);
        }

        public IEnumerable<string> ExtractValue(string elementName)
        {
            return ExtractElement(elementName).Select(i => i.Value);
        }

        public IEnumerable<string> ExtractAttribute(string elementName, string attributeName)
        {
            return ExtractElement(elementName).Select(i => i.Attribute(attributeName)).Select(i => i.Value);
        }

        private IEnumerable<XElement> ExtractElement(string elementName)
        {
            return _content.Descendants(elementName);
        }

        public IEnumerable<XElement> GetDependencies()
        {
            return ExtractElement("dependency");
        }
    }
}