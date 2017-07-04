using System.Collections.Generic;
using System.Xml.Linq;
using DotNetCoreConverter.Elements;

namespace DotNetCoreConverter.PropertyGroups
{
    public class AssemblyData : PropertyGroup
    {
        public AssemblyData(IEnumerable<XElement> elements) : base(null, elements)
        {
            
        }
    }

    public class AssemblyDataBuilder
    {
        TargetFramework framework;
        PackageId packageId;
        Authors authors;
        Company company;
        Product product;
        Description description;
        Copyright copyright;
        PackageTags packageTags;
        PackageReleaseNotes packageReleaseNotes;
        AssemblyName assemblyName;
        RootNamespace rootNamespace;

        public AssemblyDataBuilder()
        {
            
        }

        public AssemblyData Build()
        {
            List<XElement> elements = new List<XElement>();
            elements.Add(framework);
            elements.Add(packageId);
            elements.Add(authors);
            elements.Add(company);
            elements.Add(product);
            elements.Add(description);
            elements.Add(copyright);
            elements.Add(packageTags);
            elements.Add(packageReleaseNotes);
            elements.Add(assemblyName);
            elements.Add(rootNamespace);

            return new AssemblyData(elements);
        }

        public AssemblyDataBuilder WithTargetFramework(string value)
        {
            this.framework = new TargetFramework(value);
            return this;
        }

        public AssemblyDataBuilder WithPackageId(string value)
        {
            this.packageId = new PackageId(value);
            return this;
        }

        public AssemblyDataBuilder WithAuthors(string value)
        {
            this.authors = new Authors(value);
            return this;
        }

        public AssemblyDataBuilder WithCompany(string value)
        {
            this.company = new Company(value);
            return this;
        }

        public AssemblyDataBuilder WithProduct(string value)
        {
            this.product = new Product(value);
            return this;
        } 

        public AssemblyDataBuilder WithDescription(string value)
        {
            this.description = new Description(value);
            return this;
        }

        public AssemblyDataBuilder WithCopyright(string value)
        {
            this.copyright = new Copyright(value);
            return this;
        }

        public AssemblyDataBuilder WithPackageTags(string value)
        {
            this.packageTags = new PackageTags(value);
            return this;
        }

        public AssemblyDataBuilder WithPackageReleaseNotes(string value)
        {
            this.packageReleaseNotes = new PackageReleaseNotes(value);
            return this;
        }

        public AssemblyDataBuilder WithAssemblyName(string value)
        {
            this.assemblyName = new AssemblyName(value);
            return this;
        }

        public AssemblyDataBuilder WithRootNamespace(string value)
        {
            this.rootNamespace = new RootNamespace(value);
            return this;
        }

    }
}