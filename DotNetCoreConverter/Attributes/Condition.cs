using System.Xml.Linq;

namespace DotNetCoreConverter.Attributes
{
    public class Condition : XAttribute
    {
        public Condition(string value) : base("Condition", value)
        {

        } 
    }
}