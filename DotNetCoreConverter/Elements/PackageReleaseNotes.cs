using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class PackageReleaseNotes : XElement
    {
        public PackageReleaseNotes(string value) : base("PackageReleaseNotes", value)
        {
            
        }
    }
}