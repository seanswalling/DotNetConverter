using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class Company : XElement
    {
        public Company(string value) : base("Company", value)
        {
            
        }
    }
}