using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class Version : XElement
    {
        public Version(string value) : base("Version", value)
        {
            
        }
    }
}