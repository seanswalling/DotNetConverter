using System.Xml.Linq;

namespace DotNetCoreConverter.Attributes
{
    public class Include : XAttribute
    {
        public Include(string value) : base("Include", value)
        {

        }
    }
}