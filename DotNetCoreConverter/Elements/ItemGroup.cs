using System.Collections.Generic;
using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class ItemGroup : XElement
    {
        public ItemGroup(IEnumerable<XAttribute> attributes, IEnumerable<XElement> elements) : base("ItemGroup", attributes, elements)
        {

        }

        public ItemGroup(XAttribute attribute, IEnumerable<XElement> elements) : base("ItemGroup", attribute, elements)
        {

        }

        public ItemGroup(IEnumerable<XAttribute> attributes, XElement element) : base("ItemGroup", attributes, element)
        {

        }

        public ItemGroup(IEnumerable<XAttribute> attributes) : base("ItemGroup", attributes)
        {

        }

        public ItemGroup(IEnumerable<XElement> elements) : base("ItemGroup", elements)
        {

        }

        public ItemGroup(XAttribute attribute) : base("ItemGroup", attribute)
        {

        }

        public ItemGroup(XElement element) : base("ItemGroup", element)
        {

        }

        public ItemGroup() : base("ItemGroup")
        {

        }
    }
}