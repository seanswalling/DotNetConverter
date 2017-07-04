using System.Xml.Linq;
using DotNetCoreConverter.Attributes;

namespace DotNetCoreConverter.Elements
{
    public class PackageReference : XElement
    {
        public PackageReference(string include, string version) : 
            base("PackageReference", new Include(include), new Version(version))
        {

        }
    }
}