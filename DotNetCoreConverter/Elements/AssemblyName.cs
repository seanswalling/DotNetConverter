using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class AssemblyName : XElement
    {
        public AssemblyName(string value) : base("AssemblyName", value)
        {
            
        }
    }
}