using System.ComponentModel;
using Spectre.CommandLine.Annotations;

namespace DotnetCake {
    public class CakeSettings {
        [Option("-s|--script")]
        [Description("The Cake file to execute, defaults to build.cake.")]
        public string Script { get; set; }

        [Option("-t|--target")]
        [Description("The Cake task to target, defaults to Default.")]
        public string Target { get; set; }

        [Option("-c|--configuration")]
        [Description("The configuration to execute.")]
        public string Configuration { get; set; }

        [Option("-v:--verbosity")]
        [Description("The log level, defaults to verbose.")]
        public string Verbosity { get; set; }

        [Option("-r|--skipToolPacakageRestore")]
        [Description("Allows skipping Cake package restore, default is false.")]
        public bool SkipToolPackageRestore { get; set; }

        public string ScriptArgs { get; set; }
    }
}