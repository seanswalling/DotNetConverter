using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class RootNamespace : XElement
    {
        public RootNamespace(string value) : base("RootNamespace", value)
        {
            
        }
    }
}