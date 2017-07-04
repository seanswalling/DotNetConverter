using System.Collections.Generic;
using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class PropertyGroup : XElement
    {
        public PropertyGroup(IEnumerable<XAttribute> attributes, IEnumerable<XElement> elements) : base("PropertyGroup", attributes, elements)
        {

        }

        public PropertyGroup(XAttribute attribute, XElement element) : base("PropertyGroup", attribute, element)
        {

        }
    }
}