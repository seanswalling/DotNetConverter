using System.Collections.Generic;
using DotNetCoreConverter.Attributes;
using DotNetCoreConverter.Elements;

namespace DotNetCoreConverter.ItemGroups
{
    public class PackageReferences : ItemGroup
    {
        public PackageReferences(Condition condition, IEnumerable<PackageReference> references) : base(condition, references)
        {

        }
    }
}