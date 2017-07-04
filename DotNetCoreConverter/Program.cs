using System;
using System.IO;

namespace DotNetCoreConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator translator = new Translator();
            Console.WriteLine("Please Provide a path to an old csproj: ");
            string path = Console.ReadLine();
            translator.Translate(path);
        }
    }
}
