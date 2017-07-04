using System;
using System.IO;
using DotNetCoreConverter.Models;
using DotNetCoreConverter.Parsers;

namespace DotNetCoreConverter.Loaders
{
    public class ProjectLoader : Loader<Project>
    {
        private static string _proj;


        public ProjectLoader(string path)
        {
            _proj = path;
        }

        public Project Load()
        {
            OldCsProjParser ProjectParser = new OldCsProjParser(_proj);
            
            //Logic to build model
            Project proj = new Project();
            
            proj.ProjectReferences = ProjectParser.GetProjectReferences();
            
            return proj;
        }
    }
}