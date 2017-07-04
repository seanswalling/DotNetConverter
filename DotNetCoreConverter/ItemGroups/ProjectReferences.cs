using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using DotNetCoreConverter.Elements;

namespace DotNetCoreConverter.ItemGroups
{
    public class ProjectReferences : ItemGroup
    {
        public ProjectReferences(IEnumerable<ProjectReference> references) : base(references)
        {

        }
    }
}