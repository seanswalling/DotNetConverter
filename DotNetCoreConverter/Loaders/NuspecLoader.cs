using System.Collections.Generic;
using System.Linq;
using DotNetCoreConverter.Models;
using DotNetCoreConverter.Parsers;

namespace DotNetCoreConverter.Loaders
{
    public class NuspecLoader : Loader<Nuspec>
    {
        private string _path;
        public NuspecLoader(string path)
        {
            _path = path;
        }
        
        public Nuspec Load()
        {
            NuspecFileParser parser = new NuspecFileParser(_path);
            Nuspec nuspec = new Nuspec();

            nuspec.id = parser.ExtractValue("id").Single();
            nuspec.version = parser.ExtractValue("version").Single();
            nuspec.title = parser.ExtractValue("title").Single();
            nuspec.authors = parser.ExtractValue("authors").Single();
            nuspec.owners = parser.ExtractValue("owners").Single();
            nuspec.projectUrl = parser.ExtractValue("projectUrl").Single();
            nuspec.requireLicenseAcceptance = parser.ExtractValue("requireLicenseAcceptance").Single();
            nuspec.description = parser.ExtractValue("description").Single();
            nuspec.releaseNotes = parser.ExtractValue("releaseNotes").Single();
            nuspec.copyright = parser.ExtractValue("copyright").Single();
            nuspec.tags = parser.ExtractValue("tags").Single();

            var deps = parser.GetDependencies();

            List<Dependency> dependencies = new List<Dependency>();

            foreach (var dep in deps)
            {
                Dependency dependency = new Dependency();
                dependency.id = dep.Attribute("id").Value;
                dependency.version = dep.Attribute("version").Value;
                dependencies.Add(dependency);
            }

            nuspec.dependencies = dependencies;

            return nuspec;
        }
    }
}