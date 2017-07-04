using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class PackageId : XElement
    {
        public PackageId(string value) : base("PackageId", value)
        {
            
        }
    }
}