using System;
using DotNetCoreConverter.Models;
using DotNetCoreConverter.Parsers;

namespace DotNetCoreConverter.Loaders
{
    public class AssemblyInfoLoader : Loader<AssemblyInfo>
    {
        private static string _path;

        public AssemblyInfoLoader(string path)
        {
            _path = path;
        }

        public AssemblyInfo Load()
        {
            AssemblyInfoParser parser = new AssemblyInfoParser(_path);
            AssemblyInfo assemblyInfo = new AssemblyInfo();

            assemblyInfo.assemblyTitle = parser.GetValue("AssemblyTitle");
            assemblyInfo.assemblyDescription = parser.GetValue("AssemblyDescription");
            assemblyInfo.assemblyConfiguration = parser.GetValue("AssemblyConfiguration");
            assemblyInfo.assemblyCompany = parser.GetValue("AssemblyCompany");
            assemblyInfo.assemblyProduct = parser.GetValue("AssemblyProduct");
            assemblyInfo.assemblyCopyright = parser.GetValue("AssemblyCopyright");
            assemblyInfo.assemblyTrademark = parser.GetValue("AssemblyTrademark");
            assemblyInfo.assemblyCulture = parser.GetValue("AssemblyCulture");
            assemblyInfo.ComVisible = parser.GetValue("ComVisible");
            assemblyInfo.Guid = parser.GetValue("Guid");
            assemblyInfo.assemblyVerion = parser.GetValue("AssemblyVersion");
            assemblyInfo.assemblyFileVersion = parser.GetValue("AssemblyFileVersion");

            return assemblyInfo;
        }
    }
}