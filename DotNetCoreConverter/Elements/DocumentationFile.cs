using System.Xml.Linq;

namespace DotNetCoreConverter.Elements
{
    public class DocumentationFile : XElement
    {
        public DocumentationFile(string path) : base("DocumentationFile", path)
        {
            
        }
    }
}