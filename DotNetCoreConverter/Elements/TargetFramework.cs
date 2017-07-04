using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class TargetFramework : XElement
    {
        public TargetFramework(string value) : base("TargetFramework", value)
        {

        }
    }
}