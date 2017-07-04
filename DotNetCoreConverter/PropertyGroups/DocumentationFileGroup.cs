using DotNetCoreConverter.Attributes;
using DotNetCoreConverter.Elements;

namespace DotNetCoreConverter.PropertyGroups
{
    public class DocumentationFileGroup : PropertyGroup
    {
        public DocumentationFileGroup(Condition condition, DocumentationFile documentationFile) : base(condition, documentationFile)
        {
            
        }
    }
}