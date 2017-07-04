using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DotNetCoreConverter.Parsers
{
    public class AssemblyInfoParser : Parser
    {
        private IEnumerable<string> contents;

        public AssemblyInfoParser(string path)
        {
            contents = File.ReadAllLines(path);
        }

        public string GetValue(string tag)
        {
            return contents.Where(i => i.StartsWith("[assembly:"))
                    .Where(i => i.Contains(tag))
                    .Select(i => i.Split(new[]{'(',')'})[1])
                    .Single();
        }
    }
}