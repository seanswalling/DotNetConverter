using System.Collections.Generic;
using DotNetCoreConverter.Models;
using DotNetCoreConverter.Parsers;

namespace DotNetCoreConverter.Loaders
{
    public class PackagesConfigLoader : Loader<PackageConfig>
    {
        string _path;

        public PackagesConfigLoader(string path)
        {
            _path = path;
        }

        public PackageConfig Load()
        {
            PackagesConfigParser parser = new PackagesConfigParser(_path);
            PackageConfig packageConfig = new PackageConfig();
            List<Package> packages = new List<Package>();
            
            var pkgelements = parser.GetPackageReferences();
            
            foreach (var element in pkgelements)
            {
                Package package = new Package();
                package.id = element.Attribute("id").Value;
                package.version = element.Attribute("version").Value;
                package.targetFramework = element.Attribute("targetFramework").Value;
                packages.Add(package);
            }
            
            packageConfig.Packages = packages;

            return packageConfig;
        }
    }
}