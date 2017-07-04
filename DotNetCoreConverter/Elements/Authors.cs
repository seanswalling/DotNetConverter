using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class Authors : XElement
    {
        public Authors(string value) : base("Authors", value)
        {
            
        }
    }
}