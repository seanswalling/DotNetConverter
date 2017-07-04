using System.Xml.Linq;
using DotNetCoreConverter.Attributes;

namespace DotNetCoreConverter.Elements
{
    public class ProjectReference : XElement
    {
        public ProjectReference(string reference) : base("ProjectReference", new Include(reference))
        {

        }
    }
}