using System.Collections.Generic;
using System.Xml.Linq;
using DotNetCoreConverter.Attributes;
using DotNetCoreConverter.ItemGroups;
using DotNetCoreConverter.PropertyGroups;

namespace DotNetCoreConverter
{
    public class NewCsProj : XElement
    {
        public NewCsProj(AssemblyData rootlevel,
                        DocumentationFileGroup docs,
                        Folders folders,
                        ProjectReferences projectReferences,
                        PackageReferences packageReferences
                        ) : base("Project",
                                new Sdk("Microsoft.NET.Sdk"),
                                rootlevel, docs, folders, 
                                projectReferences, packageReferences)
        {

        }
    }
}