using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DotNetCoreConverter.Parsers
{
    public class OldCsProjParser : Parser
    {
        private XDocument _content;
        public OldCsProjParser(string path)
        {
            _content = XDocument.Load(path);
        }

        private IEnumerable<string> ExtractValue(string elementName)
        {
            XNamespace ns= "http://schemas.microsoft.com/developer/msbuild/2003";
            return _content.Descendants(ns + elementName).Select(i => i.Value);
        }

        private IEnumerable<string> ExtractAttribute(string elementName, string attributeName)
        {
            XNamespace ns= "http://schemas.microsoft.com/developer/msbuild/2003";
            return _content.Descendants(ns + elementName).Select(i => i.Attribute(attributeName)).Select(i => i.Value);
        }

        public IEnumerable<string> GetProjectReferences()
        {
            return ExtractAttribute("ProjectReference", "Include");
        }
    }
}