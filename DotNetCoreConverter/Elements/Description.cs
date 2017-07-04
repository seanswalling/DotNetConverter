using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class Description : XElement
    {
        public Description(string value) : base("Description", value)
        {
            
        }
    }
}