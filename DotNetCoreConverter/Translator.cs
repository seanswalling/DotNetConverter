using System.IO;
using DotNetCoreConverter;
using DotNetCoreConverter.Builder;
using DotNetCoreConverter.Loaders;
using DotNetCoreConverter.Models;

namespace DotNetCoreConverter
{
    //Take in the different FileParser/Models
    //Take in the new File Builder / Model
    //Translate from the Parsers into the Builder.
    public class Translator
    {
        public void Translate(string projpath)
        {
            var rootpath = Path.GetDirectoryName(projpath);
            Project proj = new ProjectLoader(projpath).Load();
            AssemblyInfo ai = new AssemblyInfoLoader(Path.Combine(rootpath, @"Properties\AssemblyInfo.cs")).Load();
            Nuspec nuspec = new NuspecLoader(Path.Combine(rootpath, Path.GetFileNameWithoutExtension(projpath) + ".nuspec")).Load();
            PackageConfig packageConfig = new PackagesConfigLoader(Path.Combine(rootpath, "packages.config")).Load();

            ProjectBuilder builder = new ProjectBuilder();
            builder.Build(proj, ai, packageConfig, nuspec);
            builder.Save(@"C:\Users\sean.swalling\Desktop\DotNetCoreConverter\test.xml");
        }
    }
}