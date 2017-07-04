using System.Collections.Generic;
using System.Xml.Linq;
using DotNetCoreConverter.Elements;

namespace DotNetCoreConverter.ItemGroups
{
    public class Folders : ItemGroup
    {
        public Folders(IEnumerable<Folder> folders) : base(folders)
        {
            
        }
    }
}