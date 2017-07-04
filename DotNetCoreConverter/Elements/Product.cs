using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class Product : XElement
    {
        public Product(string value) : base("Product", value)
        {
            
        }
    }
}