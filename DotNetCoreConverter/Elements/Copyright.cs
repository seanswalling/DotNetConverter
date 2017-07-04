using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class Copyright : XElement
    {
        public Copyright(string value) : base("Copyright", value)
        {
            
        }
    }
}