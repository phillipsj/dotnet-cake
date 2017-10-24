using System;

namespace DotnetCake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Options
    {
        public string Script { get; set; }
        public string Target { get; set; }
        public string Configuration { get; set; }
        public string Verbosity { get; set; }
        public bool SkipToolPackageRestore { get; set; }
        public string ScriptArgs { get; set; }
    }
}
