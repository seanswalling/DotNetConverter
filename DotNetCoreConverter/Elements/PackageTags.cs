using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class PackageTags : XElement
    {
        public PackageTags(string value) : base("PackageTags", value)
        {
            
        }
    }
}