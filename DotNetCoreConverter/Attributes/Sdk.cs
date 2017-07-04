using System.Xml.Linq;

namespace DotNetCoreConverter.Attributes
{
    public class Sdk : XAttribute
    {
        public Sdk(string value) : base("Sdk", value)
        {
            
        }
    }
}