using System.Xml.Linq;
using DotNetCoreConverter.Attributes;

namespace DotNetCoreConverter.Elements
{
    public class Folder : XElement
    {
        public Folder(string folderName) : base("Folder", new Include(folderName))
        {
            
        }
    }
}