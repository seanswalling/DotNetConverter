using System.Collections.Generic;

namespace DotNetCoreConverter.Models
{
    public class Nuspec
    {
        public string id {get;set;}
        public string version {get;set;}
        public string title {get;set;}
        public string authors {get;set;}
        public string owners {get;set;}
        public string projectUrl {get;set;}
        public string requireLicenseAcceptance {get;set;}
        public string description {get;set;}
        public string releaseNotes {get;set;}
        public string copyright {get;set;}
        public string tags {get;set;}
        public IEnumerable<Dependency> dependencies {get;set;}
    }
}