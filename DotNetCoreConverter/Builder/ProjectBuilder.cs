using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using DotNetCoreConverter.Attributes;
using DotNetCoreConverter.Elements;
using DotNetCoreConverter.ItemGroups;
using DotNetCoreConverter.Models;
using DotNetCoreConverter.PropertyGroups;

namespace DotNetCoreConverter.Builder
{
    public class ProjectBuilder
    {
        private Models.Project _project;
        private AssemblyInfo _assemblyInfo;
        private PackageConfig _packageConfig;
        private Nuspec _nuspec;
        private XDocument _xdoc;
        private AssemblyData _assemblyData;
        private DocumentationFileGroup _docs;
        private ProjectReferences _projectReferences;
        private PackageReferences _packageReferences;

        public void Build(Models.Project project, AssemblyInfo assemblyInfo, PackageConfig packageConfig, Nuspec nuspec)
        {
            _project = project;
            _assemblyInfo = assemblyInfo;
            _packageConfig = packageConfig;
            _nuspec = nuspec;
            //Build model
            BuildModel();

            _xdoc = new XDocument(null, BuildNewCsProj());
        }

        public void Save(string path)
        {
            //save to file location
            FileStream fs = new FileStream(path, FileMode.Create);
            _xdoc.Save(fs);
        }

        private void BuildModel()
        {
            _docs = BuildDocumentationFile("Debug", "net451", "AnyCPU", _nuspec.title);
            _assemblyData = BuildAssemblyData();
            _projectReferences = new ProjectReferences(BuildProjectReferences());
            _packageReferences = new PackageReferences(null, BuildPackageReferences());
        }

        private AssemblyData BuildAssemblyData()
        {
            return new AssemblyDataBuilder()
                        .WithTargetFramework("net451")
                        .WithPackageId(_nuspec.id)
                        .WithAuthors(_nuspec.authors)
                        .WithCompany(_nuspec.authors)
                        .WithProduct(_nuspec.title)
                        .WithDescription(_nuspec.description)
                        .WithCopyright(_nuspec.copyright)
                        .WithPackageTags(_nuspec.tags)
                        .WithAssemblyName(_nuspec.title)
                        .WithRootNamespace(_nuspec.title)
                        .Build();
        }

        private IEnumerable<ProjectReference> BuildProjectReferences()
        {
            return _project.ProjectReferences.Select(pr => new ProjectReference(pr));
        }

        private IEnumerable<PackageReference> BuildPackageReferences()
        {
            return _packageConfig.Packages.Select(i => new PackageReference(i.id, i.version));
        }

        private DocumentationFileGroup BuildDocumentationFile(string config, string framework, string platform, string filenameWithoutExt)
        {
            var condition = new Condition($"'$(Condition)|$(TargetFramework)|$(Platform)'=='{config}|{framework}|{platform}'");
            var documentation = new DocumentationFile($"bin\\{config}\\{framework}\\{filenameWithoutExt}.xml");
            return new DocumentationFileGroup(condition, documentation);
        }

        private NewCsProj BuildNewCsProj()
        {
            return new NewCsProj(_assemblyData, _docs, null, _projectReferences, _packageReferences);
        }
    }
}